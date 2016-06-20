using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MGE.GamingEngine.SlotsEngine.SlotsCommunicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISlotsEngineCommunicator
    {

        [OperationContract]
        bool SubmitGameRound(GameRound gameRound);

        [OperationContract]
        [WebInvoke(UriTemplate = "/StartEngine", Method = "POST")]
        GameEngineComposite StartEngine();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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


    [DataContract]
    public class GameEngineComposite
    {
        public GameEngineComposite()
        {

        }

        public GameEngineComposite(MGE.GameEntities.Engines.Interfaces.IGameEngine GameEngine)
        {
            this._GameEngine = GameEngine;
        }


        private MGE.GameEntities.Engines.Interfaces.IGameEngine  _GameEngine = null;

        [DataMember]
        public int GameEngineId
        {
            get { return _GameEngine.GameEngineId; }
            set { _GameEngine.GameEngineId = value; }
        }

        [DataMember]
        public string GameEngineName
        {
            get { return _GameEngine.GameEngineName; }
            set { _GameEngine.GameEngineName = value; }
        }

        [DataMember]
        public string GameEngineType
        {
            get { return _GameEngine.GameEngineType; }
            set { _GameEngine.GameEngineType = value; }
        }         

        [DataMember]
        public DateTime StartTime
        {
            get { return _GameEngine.StartTime; }
            set { _GameEngine.StartTime = value; }
        }
    }
}
