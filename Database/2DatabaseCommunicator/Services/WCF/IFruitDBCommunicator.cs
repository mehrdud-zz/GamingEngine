using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DatabaseCommunicator.Services.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFruitDBCommunicator" in both code and config file together.
    [ServiceContract]
    public interface IFruitDBCommunicator
    {
        [OperationContract]
        void Add(MGE.GamingEngine.Standard.Interfaces.IFruit fruit);
    }
}
