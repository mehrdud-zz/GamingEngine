using System;
using MGE.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEngine.GameEngine
{
    public abstract class GameRoundSubmit
    {
        private readonly MGE.StandardGamingFactories.Standard.Interfaces.IGameMachineFactory _GameMachineFactory;

        public GameRoundSubmit()
        {
        }


        [DeveloperAttribute("test", "StartGameSession")]
        public virtual Slots.Interfaces.Session.IGameSession StartGameSession(
            Slots.Interfaces.Session.IPlayerSession playerSession)
        {
            MGE.Utilities.Logger.Log("StartGameSession");
            throw new NotImplementedException();
        }
    }
}
