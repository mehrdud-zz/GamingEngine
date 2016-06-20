using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Engines.Entities
{
    public abstract class GameEngine : Interfaces.IGameEngine
    {
        public virtual int GameEngineId { get; set; }

        public virtual string GameEngineName { get; set; }

        public virtual string GameEngineStatus { get; set; }

        public virtual string GameEngineType { get; set; } 

        public virtual DateTime StartTime { get; set; }

        public virtual Dictionary<string, string> GetServerDetails()
        {
            var serverDetails = new Dictionary<string, string>();
            serverDetails.Add("GameEngineName", this.GameEngineName);
            serverDetails.Add("GameEngineType", this.GameEngineType);
            return serverDetails;
        }
    }
}
