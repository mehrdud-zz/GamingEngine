using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Sessions.SessionEntities
{
    class GameSession : Interfaces.Session.IGameSession
    {
        public Guid PlayerSessionId { get; set; }
        public Guid GameSessionId { get; set; }
    }
}
