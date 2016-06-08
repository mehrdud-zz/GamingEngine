using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG.GameFactories.GameEngine.Factories;
using MGE.GameEntities.Engines.Interfaces;

namespace MGE.GamingEngine.PokerEngine.Factories.Engine
{
    public class PokerEngineFactory : MEG.GameFactories.GameEngine.Factories.IGameEngineFactory
    {
        public string GetServiceDetails(IGameEngine gameEngine)
        {
            return gameEngine.GetServerDetails().ToString();
        }

        public IGameEngine StartEngine()
        {
            var gameEngine = new MGE.GamingEngine.PokerEngine.Entities.Engine.PokerEngine();
            return gameEngine;
        }
    }
}
