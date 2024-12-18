using System.Linq;

namespace johnny.HexProject.Logic
{
    public class Tile
    {
        private readonly IBoard _board;
        public IPosition Position { get; }

        public Tile(IPosition position, IBoard board)
        {
            Position = position;
            _board = board;
        }
        
        public bool IsOccupied
        {
            get => Position.IsOccupied;
            set => Position.IsOccupied = value;
        }
        
        public Tile GetTileTowards(IPosition target)
        {
            var neighbors = Position.GetNeighbours();
            return neighbors
                .Select(coord => _board.GetTile(coord))
                .Where(tile => tile is { Position: { IsOccupied: false } })
                .OrderBy(tile => tile.Position.GetDistance(target))
                .FirstOrDefault();
        }
    }
}