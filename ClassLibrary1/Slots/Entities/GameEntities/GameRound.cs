using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG.GamingEngine.Standard.Entities
{
    public class GameRound
    {
        public Guid GameRoundId { get; set; }
        public Guid GameId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
