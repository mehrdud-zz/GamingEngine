using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Sessions.SessionEntities
{
    public abstract class PlayerSession : Interfaces.Session.IPlayerSession
    {
        public int PlayerSessionId { get; set; }
        public string SessionSource { get; set; }
    }
}
