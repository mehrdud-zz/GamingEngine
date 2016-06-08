using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DatabaseCommunicator.Services.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FruitDBCommunicator" in both code and config file together.
    public class FruitDBCommunicator : IFruitDBCommunicator
    {
        public void Add(MGE.GamingEngine.Standard.Interfaces.IFruit fruit)
        {
            var fruitController = new MGE.GamingEngine.DBLayer.Controller.FruitController();
            
            fruitController.Add(fruit);
        }
    }
}
