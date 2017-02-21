using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Model.Dimension.Grids
{
    public static class GridUtility
    {
        public static double CalculateEuclideanDistance(this Grid targetGrid, GridLocation source, GridLocation target)
        {
            return CalculateEuclideanDistance(source, target);
        }

        public static double CalculateEuclideanDistance(GridLocation source, GridLocation target)
        {
            return CalculateEuclideanDistance(source.X, source.Y, target.X, target.Y);
        }

        public static double CalculateEuclideanDistance(this Grid targetGrid, int x1, int y1, int x2, int y2)
        {
            return CalculateEuclideanDistance(x1, y1, x2, y2);
        }

        public static double CalculateEuclideanDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
        }
    }
}

