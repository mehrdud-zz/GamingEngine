using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Game.Interfaces
{
    interface IGameRound
    {
        Guid GameRoundId { get; set; }
        Guid GameId { get; set; }
        DateTime TimeStamp { get; set; }
    }
}
