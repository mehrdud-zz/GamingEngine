using System;
using MGE.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEngine.GameEngine
{
    public abstract class TableGameRoundSubmit : GameRoundSubmit
    {
        private readonly MGE.StandardGamingFactories.Standard.Interfaces.IGameMachineFactory _GameMachineFactory;

        public TableGameRoundSubmit()
        {
        }


        [DeveloperAttribute("test", "StartGameSession-Table")]
        public override Slots.Interfaces.Session.IGameSession StartGameSession(
            Slots.Interfaces.Session.IPlayerSession playerSession)
        {
            MGE.Utilities.Logger.Log("DeveloperAttriute");
            throw new NotImplementedException();
        }
    }
}
