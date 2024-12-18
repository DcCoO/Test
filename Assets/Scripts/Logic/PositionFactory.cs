namespace johnny.HexProject.Logic
{
    public static class PositionFactory
    {
        public static IPosition Create(Coordinate coordinate)
        {
            return new OddRHexPosition(coordinate);
        }
    }
}