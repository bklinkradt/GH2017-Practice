using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator.Inputs.Entities
{
    // Guidance: This is the parent input that enforces the check against specification to ensure
    //           that we dont make mistakes.
    public abstract class Input
    {
        public abstract bool IsValidAgainstSpecification();
    }
}

