using System;
using System.Collections.Generic;

namespace johnny.HexProject.Logic
{
    public interface IPlayer
    {
        int Id { get; set; }
        Tile Tile { get; set; }
        int Health { get; set; }
        void TakeDamage(int damage);
        IReadOnlyList<ICommand> Step();
        bool IsAlive { get; }
        event Action PlayerDied;
    }
}