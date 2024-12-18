using System.Linq;
using UnityEngine;

namespace johnny.HexProject.Logic
{
    public class RectangularBoard : IBoard
    {
        private readonly Tile[,] _tiles;
        public Tile[] Tiles => _tiles.Cast<Tile>().ToArray();
        public RectangularBoard(int width, int height)
        {
            Width = width;
            Height = height;
            _tiles = new Tile[width, height];
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    _tiles[i, j] = new Tile(PositionFactory.Create(new Coordinate(i, j)), this);
                }
            }
        }
        public int Width { get; }
        public int Height { get; }
        
        public Tile GetTile(Coordinate coordinate)
        {
            if(coordinate.I < 0 || coordinate.I >= Width || coordinate.J < 0 || coordinate.J >= Height)
                return null;
            return _tiles[coordinate.I, coordinate.J];
        }

        public Tile GetRandomTile()
        {
            return _tiles[Random.Range(0, Width), Random.Range(0, Height)];
        }
    }
}