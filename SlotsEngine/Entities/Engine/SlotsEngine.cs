using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GamingEngine.SlotsEngine.Entities.Engine
{
    public class SlotsEngine : MGE.GameEntities.Engines.Entities.GameEngine
    { 
        public override string GameEngineType
        {
            get
            {
                return "SlotsEngine";
            }
        }
    }
}
