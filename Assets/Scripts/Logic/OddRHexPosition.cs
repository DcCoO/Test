namespace johnny.HexProject.Logic
{
    public class OddRHexPosition : IPosition
    {
        private readonly float dx = (float)System.Math.Sqrt(3) / 2f;
        private readonly Coordinate[]  neighbours;
        private int Shift => Coordinate.J % 2;
        public OddRHexPosition(Coordinate coordinate)
        {
            Coordinate = coordinate;
            neighbours =     new[]    {
                Add(-1, +0), // east
                Add(Shift - 1, +1), // north-east
                Add(Shift + 0,+1), // north-west
                Add(+1, +0), // west
                Add(Shift + 0, -1), // south-west
                Add(Shift - 1, -1) // south-east
            }; 
        }
        public Coordinate Coordinate { get; }
        public bool IsOccupied { get; set; }
        Coordinate Add(int i, int j)
        {
            return new Coordinate(Coordinate.I + i, Coordinate.J + j);
        }
        
        (int, int, int) OddRToCube(Coordinate i)
        {
            var q = i.I - (i.J - (i.J & 1)) / 2;
            var r = i.J;
            return (q, r, -q - r);
        }
        
        public int GetDistance(IPosition position)
        {
            var (q1, r1, s1) = OddRToCube(Coordinate);
            var (q2, r2, s2) = OddRToCube(position.Coordinate);
            return (System.Math.Abs(q1 - q2) + System.Math.Abs(r1 - r2) + System.Math.Abs(s1 - s2)) / 2;
        }
        public Coordinate[] GetNeighbours()
        {
            return neighbours;
        }

        public (float, float, float) To3D()
        {
            var x = dx * Coordinate.I * 2 + (Coordinate.J % 2 == 0 ? 0 : dx);
            var y = 1.5f * Coordinate.J;
            return (x, y, 0);
        }
    }
}