using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Model.Dimension.Grids
{
    public class Grid
    {
        public int Rows { get; private set; }

        public int Columns { get; private set; }

        public Grid(
            int rows,
            int columns)
        {
            Rows = rows;
            Columns = columns;
        }
    }
}

