using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Game.Entities
{
    public abstract class Game : Interfaces.IGame
    {
        public Guid GameId { get; set; }
    }
}
