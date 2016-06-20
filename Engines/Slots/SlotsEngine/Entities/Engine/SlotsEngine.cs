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


        public override int GameEngineId { get; set; }

        public override string GameEngineName { get; set; }

        public override string GameEngineStatus { get; set; }
         

        public override DateTime StartTime { get; set; }
    }
}
