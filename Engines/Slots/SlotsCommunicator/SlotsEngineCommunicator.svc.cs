using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RabbitMQ.Client;


namespace MGE.GamingEngine.SlotsEngine.SlotsCommunicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SlotsEngineCommunicator : ISlotsEngineCommunicator
    {

        MEG.GameFactories.GameEngine.Factories.IGameEngineFactory gameEngineFactory = null;

        public SlotsEngineCommunicator()
        {

        }

        public SlotsEngineCommunicator(MEG.GameFactories.GameEngine.Factories.IGameEngineFactory gameEngineFactory)
        {
            this.gameEngineFactory = gameEngineFactory;
        }

        public GameEngineComposite StartEngine()
        {
            gameEngineFactory = new MGE.GamingEngine.SlotsEngine.Engine.Factories.Engine.SlotsEngineFactory("Slots");

            var gameEngine = gameEngineFactory.StartEngine();
            var gameEngineComposite = new GameEngineComposite(gameEngine);
            return gameEngineComposite;
        }

        public bool SubmitGameRound(GameRound gameRound)
        {
            return true;
        }
    }
}
