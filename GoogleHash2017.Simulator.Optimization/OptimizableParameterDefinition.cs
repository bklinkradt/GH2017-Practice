using System;

namespace GoogleHash2017.Simulator.Optimizations
{
    public class OptimizableParameterDefinition
    {
        #region Instance Properties

        public string ParameterName { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }

        #endregion

        #region Constructors

        public OptimizableParameterDefinition(
            string parameterName,
            double minValue,
            double maxValue)
        {
            ParameterName = parameterName;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        #endregion

        #region Instance Methods

        public override bool Equals(object obj)
        {
            OptimizableParameterDefinition castedParameter = obj as OptimizableParameterDefinition;
            if (castedParameter != null)
                return castedParameter.ParameterName.Equals(ParameterName, StringComparison.InvariantCultureIgnoreCase);
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return ParameterName.GetHashCode();
        }

        #endregion
    }
}

