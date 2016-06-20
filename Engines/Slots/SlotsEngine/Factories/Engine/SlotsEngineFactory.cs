using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG.GameFactories.GameEngine.Factories;
using MGE.GameEntities.Engines.Interfaces;

namespace MGE.GamingEngine.SlotsEngine.Engine.Factories.Engine
{
    public class SlotsEngineFactory : IGameEngineFactory
    {


        public SlotsEngineFactory(string engineType)
        {

        }


        public string GetServiceDetails(IGameEngine gameEngine)
        {
            return gameEngine.GetServerDetails().ToString();
        }

        public IGameEngine StartEngine()
        {
            var gameEngine = new MGE.GamingEngine.SlotsEngine.Entities.Engine.SlotsEngine();
            gameEngine.GameEngineName = "Slots" + new Random().Next();
            //var dbLayer = new MGE.DBLayer.Controller.EngineController();            
            //dbLayer.SaveGameEngine(gameEngine);
            var pushMessage = new MGE.GamingEngine.SlotsEngine.Factories.Messaging.PushMessage();
            pushMessage.PushGameEngine(gameEngine);

            return gameEngine;
        }



    }
}
