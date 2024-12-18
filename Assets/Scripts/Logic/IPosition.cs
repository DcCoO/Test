namespace johnny.HexProject.Logic
{
    public interface IPosition
    {
        Coordinate Coordinate { get; }
        
        int GetDistance(IPosition position);
        bool IsOccupied { get; set; }
        Coordinate[] GetNeighbours();
        (float, float, float) To3D();
    }
}

