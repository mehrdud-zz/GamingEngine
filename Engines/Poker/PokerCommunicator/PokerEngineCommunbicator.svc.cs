using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PokerCommunicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PokerEngineCommunicator : IPokerEngineCommunicator
    {
        public bool SubmitGameRound(GameRound gameRound)
        {
            return true;
        }
    }


    [DataContract]
    public class GameRound
    {
        public GameRound()
        {

        }

        private MGE.GameEntities.Game.Entities.GameRound gameRound;

        [DataMember]
        public Guid GameRoundId
        {
            get { return gameRound.GameRoundId; }
            set { gameRound.GameRoundId = value; }
        }


        [DataMember]
        public Guid GameId
        {
            get { return gameRound.GameId; }
            set { gameRound.GameId = value; }
        }

        [DataMember]
        public DateTime TimeStamp
        {
            get { return gameRound.TimeStamp; }
            set { gameRound.TimeStamp = value; }
        }
    }
}
