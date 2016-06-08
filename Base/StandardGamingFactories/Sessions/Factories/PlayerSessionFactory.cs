using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG.GameFactories.Sessions.Interfaces;
using MGE.GameEntities.Players.Interfaces;
using MGE.GameEntities.Sessions.Interfaces.Session;

namespace MEG.GameFactories.Sessions.Factories
{
    class PlayerSessionFactory : Interfaces.IPlayerSessionFactory
    {
        IPlayerSession IPlayerSessionFactory.CreatePlayerSession(IPlayer player)
        {
            throw new NotImplementedException();
        } 
    }
}
