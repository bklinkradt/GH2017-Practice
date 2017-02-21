namespace GoogleHash2017.Model.Dimension.Grids
{
    public class GridLocation :
        BaseEntity
    {
        public int X { get; set; }

        public int Y { get; set; }

        public GridLocation(
            int x,
            int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            GridLocation location = obj as GridLocation;
            if (location != null)
                return location.X == X && location.Y == Y;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode();
        }
    }
}

