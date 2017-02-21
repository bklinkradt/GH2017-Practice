namespace GoogleHash2017.Simulator.Optimizations
{
    public class OptimizableParameter
    {
        #region Instance Properies

        public OptimizableParameterDefinition Defintion { get; set; }

        public double ParameterValue { get; set; }

        #endregion

        #region Constructors

        public OptimizableParameter(
            OptimizableParameterDefinition defintion,
            double parameterValue)
        {
            Defintion = defintion;
            ParameterValue = parameterValue;
        }

        #endregion
    }
}

