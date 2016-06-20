using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.DBLayer.Entities.Slots
{
    public class GameEngine : GameEntities.Engines.Entities.GameEngine
    {
        public GameEngine()
        { 
        }

        public GameEngine (DateTime StartTime)
        {
            this.StartTime = StartTime;
        }
    }
}
