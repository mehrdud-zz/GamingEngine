using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.GameEngine
{
    /// <summary>
    /// In context of IoC, this class is the client that will use engine factory as a service. 
    /// </summary>
    public class EngineClient
    {
        MEG.GameFactories.GameEngine.Factories.IGameEngineFactory gameEngineFactory = null;

        public EngineClient(MEG.GameFactories.GameEngine.Factories.IGameEngineFactory gameEngineFactory)
        {
            this.gameEngineFactory = gameEngineFactory;
        }

        public string getServerDetails()
        {
            var engine = gameEngineFactory.StartEngine();
            return gameEngineFactory.GetServiceDetails(engine);
        }
    }
}
