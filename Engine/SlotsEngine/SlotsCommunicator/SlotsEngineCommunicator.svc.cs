using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RabbitMQ.Client;


namespace MGE.GamingEngine.SlotsEngine.SlotsCommunicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SlotsEngineCommunicator : ISlotsEngineCommunicator
    {

        public bool SubmitGameRound(GameRound gameRound)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "hello",
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);
                }
            }
            return true;
        }
    }
}
