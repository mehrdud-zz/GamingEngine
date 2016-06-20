using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SlotsEngineCommunicatorWebAPI.Controllers
{
    public class EngineController : ApiController
    {
        MEG.GameFactories.GameEngine.Factories.IGameEngineFactory gameEngineFactory = null;

        public MGE.GameEntities.Engines.Interfaces.IGameEngine StartEngine()
        {
            gameEngineFactory = new MGE.GamingEngine.SlotsEngine.Engine.Factories.Engine.SlotsEngineFactory("Slots");

            var gameEngine = gameEngineFactory.StartEngine(); 
            return gameEngine;
        }
    }
}
