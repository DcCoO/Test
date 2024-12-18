using System;

namespace johnny.HexProject.Logic
{
    public struct Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(int i, int j)
        {
            I = i;
            J = j;
        }
        public int I { get; }
        public int J { get; }
        
        public bool Equals(Coordinate other)
        {
            return I == other.I && J == other.J;
        }
        
        public override string ToString()
        {
            return $"[{I}, {J}]";
        }
    }
}