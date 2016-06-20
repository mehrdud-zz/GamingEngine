using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MGE.GameEntities.Standard.Interfaces;

namespace DBCommunicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGameEngineService
    {
        [OperationContract]
        void SaveGameEngine(GameEngineCompositeType gameEngine);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class GameEngineCompositeType : MGE.GameEntities.Engines.Entities.GameEngine
    {

        [DataMember]
        public override int GameEngineId { get; set; }

        [DataMember]
        public override string GameEngineStatus { get; set; }

        [DataMember]
        public override string GameEngineName { get; set; }

        [DataMember]
        public override DateTime StartTime { get; set; }

    }
}
