using GoogleHash2017.Model.Domain;
using GoogleHash2017.Simulator.Inputs;
using GoogleHash2017.Simulator.Optimizations;
using GoogleHash2017.Simulator.Strategies;
using GoogleHash2017.Simulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator
{
    public class Simulation
    {
        #region Instance Properties

        public int SimulationClock { get; set; }

        public int SimulationDeadline { get; set; }

        public SimulationAggregate SimulationAggregate { get; set; }

        #endregion

        #region Constructors

        public Simulation(
            IStrategy strategy,
            IList<OptimizableParameter> strategyParameters,
            InputReaderResult inputParameters)
        {
            // Argument validation.
            if (strategy == null)
                throw new ArgumentException("Need to specify an execution strategy for this Simulation.");

            if (strategyParameters == null &&
                strategy.OptimizableParametersDefinitions.Except(strategyParameters.Select(c => c.Defintion)).Count() > 0)
                throw new ArgumentException("Need to specify the strategy parameters that are required.");

            if (inputParameters == null ||
                !inputParameters.IsValidAgainstSpecification())
                throw new ArgumentException("Input Parameters not well formed from input source");

            // Intialize the domain elements.
            InitializeExampleSection(inputParameters);

            // Create the game grid.
            SimulationClock = 0;
            //SimulationDeadline = inputParameters.DeadlineOfSimulation;
            //SimulationGrid = new Grid(
            //    inputParameters.NumberOfRows,
            //    inputParameters.NumberOfColumns);

            _currentStrategy = strategy;
            _currentStrategyParameters = strategyParameters;
        }

        #endregion

        #region Instance Methods

        #region Initialization Methods

        private void InitializeExampleSection(
            InputReaderResult parameters)
        {
            //SimulationOrders = new List<Order>();
            //foreach (var order in parameters.CustomerOrders)
            //{
            //    Order constructedOrder = new Order();
            //    constructedOrder.TargetDelivery = new Location(order.X, order.Y);
            //    foreach (var productId in order.ProductTypes.Distinct())
            //        constructedOrder.Products.Add(
            //            SimulationProducts.FirstOrDefault(c => c.ProductType == productId),
            //            order.ProductTypes.Where(c => c == productId).Count());

            //    SimulationOrders.Add(constructedOrder);
            //}
            //ExportDataUtility.Export("Orders.csv", SimulationOrders.Select(c => c.ToString()).ToList());
        }

        #endregion

        public void Execute()
        {
            // Set the current simulation to the strategy.
            _currentStrategy.CurrentSimulation = this.SimulationAggregate;
            _currentStrategy.BeforeSimulation(_currentStrategyParameters);
            while (SimulationClock < SimulationDeadline)
            {
                _currentStrategy.OnTick(SimulationClock);
                SimulationClock++;
            }
            _currentStrategy.AfterSimulation();
        }

        #endregion

        #region Instance Fields

        private IStrategy _currentStrategy;

        private IList<OptimizableParameter> _currentStrategyParameters;

        #endregion
    }
}

