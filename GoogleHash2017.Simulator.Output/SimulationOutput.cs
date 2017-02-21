using GoogleHash2017.Simulator.Outputs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator.Outputs
{
    public class SimulationOutput :
        Output
    {
        #region Instance Properties

        // Guidance: List all of the output fields in raw field form.
        // - Implement Input.IsValidAgainstSpecification to make sure that parsed inputs matches competition rules.
        // - For complex sections abstract into entities.
        // - Do not tie to the model here yet since the model will be fleshed out whilst you do the input step.

        #endregion

        #region Constructors

        public SimulationOutput()
        {
            // Guidance: Don't forget to intialize your collections!
        }

        #endregion

        #region Instance Methods

        public override bool IsValidAgainstSpecification()
        {
            // Todo: Test all of the assumptions from the problem statement here to ensure
            //           we dont make mistakes.
            return true;
        }

        #endregion
    }
}

