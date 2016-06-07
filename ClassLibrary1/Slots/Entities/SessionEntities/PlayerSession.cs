using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.Slots.Entities.SessionEntities
{
    class PlayerSession : Interfaces.Session.IPlayerSession
    {
        public Guid PlayerSessionId { get; set; }
    }
}
