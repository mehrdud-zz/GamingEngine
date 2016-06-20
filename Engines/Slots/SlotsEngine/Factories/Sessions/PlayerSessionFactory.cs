using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG.GameFactories.Sessions.Interfaces;
using MGE.GameEntities.Players.Interfaces;
using MGE.GameEntities.Sessions.Interfaces.Session;

namespace MGE.GamingEngine.SlotsEngine.Engine.Factories.Sessions
{
    class PlayerSessionFactory : MEG.GameFactories.Sessions.Interfaces.IPlayerSessionFactory
    {
        IPlayerSession IPlayerSessionFactory.CreatePlayerSession(IPlayer player)
        {
            throw new NotImplementedException();
        }         
    }
}
