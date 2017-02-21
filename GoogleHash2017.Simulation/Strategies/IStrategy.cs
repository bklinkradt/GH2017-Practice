using GoogleHash2017.Model.Domain;
using GoogleHash2017.Simulator.Optimizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator.Strategies
{
    public interface IStrategy
    {
        SimulationAggregate CurrentSimulation { get; set; }

        OptimizableParameterDefinition[] OptimizableParametersDefinitions { get; }

        void BeforeSimulation(
            IList<OptimizableParameter> optimizableParameters);

        void OnTick(int iteration);

        void AfterSimulation();
    }
}

