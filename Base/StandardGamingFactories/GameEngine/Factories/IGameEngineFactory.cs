using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG.GameFactories.GameEngine.Factories
{
    public interface IGameEngineFactory
    {
        
        MGE.GameEntities.Engines.Interfaces.IGameEngine StartEngine();
        string GetServiceDetails(MGE.GameEntities.Engines.Interfaces.IGameEngine gameEngine);
        
    }
}
