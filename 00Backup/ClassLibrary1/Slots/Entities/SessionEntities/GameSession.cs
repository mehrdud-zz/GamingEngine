using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.Slots.Entities.SessionEntities
{
    class GameSession : Interfaces.Session.IGameSession
    {
        public Guid PlayerSessionId { get; set; }
        public Guid GameSessionId { get; set; }
    }
}
