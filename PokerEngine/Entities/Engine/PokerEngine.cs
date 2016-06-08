using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GamingEngine.PokerEngine.Entities.Engine
{
    public class PokerEngine : MGE.GameEntities.Engines.Entities.GameEngine
    {
        public override string GameEngineType
        {
            get
            {
                return "PokerEngine";
            }
        }
    }
}
