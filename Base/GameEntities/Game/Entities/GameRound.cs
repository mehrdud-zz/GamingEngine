using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Game.Entities
{
    public abstract class GameRound : Interfaces.IGameRound
    {
        public Guid GameId { get; set; }

        public Guid GameRoundId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
