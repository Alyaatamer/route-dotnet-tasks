namespace Task3.First_Project
{
    internal class Points
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Z { get; set; } 
        public Points(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"“Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static bool operator ==(Points a, Points b)
        {
            if (a is null || b is null) return false;
            if (ReferenceEquals(a, b)) return true;            
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Points a, Points b)
        {
            return !(a == b);
        }

        public class ReversePointComparer : IComparer<Points>
        {
            public int Compare(Points x, Points y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;

                if (x.X != y.X)
                    return x.X.CompareTo(y.X);
                else
                    return x.Y.CompareTo(y.Y);
            }
        }
    }
}
