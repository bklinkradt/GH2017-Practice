using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator.Outputs.Entities
{
    // Guidance: This is the parent output that enforces the check against specification to ensure
    //           that we dont make mistakes.
    public abstract class Output
    {
        public abstract bool IsValidAgainstSpecification();
    }
}

