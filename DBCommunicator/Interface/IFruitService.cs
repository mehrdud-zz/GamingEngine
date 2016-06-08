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
    public interface IFruitService
    {
        [OperationContract]
        void Add(FruitCompositeType fruit);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class FruitCompositeType : MGE.GameEntities.Standard.Interfaces.IFruit
    {

        private int _FruitId { get; set; }
        private string _Name { get; set; }
        private string _ImageURL { get; set; }

        [DataMember]
        public int FruitId
        {
            get { return _FruitId; }
            set { _FruitId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public string ImageURL
        {
            get { return _ImageURL; }
            set { _ImageURL = value; }
        }
    }
}
