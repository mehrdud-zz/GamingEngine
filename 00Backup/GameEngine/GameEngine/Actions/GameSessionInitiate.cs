using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEngine.GameEngine
{
    public abstract class GameSessionInitiate
    {
        private readonly MGE.StandardGamingFactories.Standard.Interfaces.IGameMachineFactory _GameMachineFactory;

        public GameSessionInitiate()
        {
            this._GameMachineFactory = null;
        }

        public GameSessionInitiate(MGE.StandardGamingFactories.Standard.Interfaces.IGameMachineFactory gameMachineFactory)
        {
            this._GameMachineFactory = gameMachineFactory;
        }

        public virtual Slots.Interfaces.Session.IGameSession StartGameSession(            
            Slots.Interfaces.Session.IPlayerSession playerSession)
        {
            MGE.Utilities.Logger.Log("StartGameSession");
            throw new NotImplementedException();
        }

        public virtual Slots.Interfaces.Session.IGameSession EndGameSession(
            Slots.Interfaces.Session.IGameSession gameSession,
            Slots.Interfaces.Session.IPlayerSession playerSession)
        {
            MGE.Utilities.Logger.Log("EndGameSession");
            throw new NotImplementedException();
        }
    }
}
