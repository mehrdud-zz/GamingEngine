using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG.GameFactories.Sessions.Interfaces
{
    public interface IPlayerSessionFactory
    {
        MGE.GameEntities.Sessions.Interfaces.Session.IPlayerSession CreatePlayerSession(MGE.GameEntities.Players.Interfaces.IPlayer player);
    }
}
