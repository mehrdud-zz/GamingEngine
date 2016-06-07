using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SlotsCommunicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISlotsEngineCommunicator
    {

        [OperationContract]
        bool SubmitGameRound(GameRound gameRound);



        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class GameRound
    {
        public GameRound()
        {
            this.gameRound = new MEG.GamingEngine.Standard.Entities.GameRound();
        }


        public GameRound(MEG.GamingEngine.Standard.Entities.GameRound gameRound)
        {
            this.gameRound = gameRound;
        }

        private MEG.GamingEngine.Standard.Entities.GameRound gameRound;

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
