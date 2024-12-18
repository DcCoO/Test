namespace johnny.HexProject.Logic
{
    public interface IBoard
    {
        Tile[] Tiles { get; }
        Tile GetTile(Coordinate coordinate);
        Tile GetRandomTile();
    }
}