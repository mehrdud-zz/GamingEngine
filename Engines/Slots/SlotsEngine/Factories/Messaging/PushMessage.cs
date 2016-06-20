using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GamingEngine.SlotsEngine.Factories.Messaging
{
    public class PushMessage
    {

        public void PushGameEngine(MGE.GamingEngine.SlotsEngine.Entities.Engine.SlotsEngine engine)
        {
            this.PushGameEngine("localhost", "GamingEngine", "", "", engine);

        }

        public void PushGameEngine(string hostName, string queueName, string routingKey, string exchangeString,
            MGE.GamingEngine.SlotsEngine.Entities.Engine.SlotsEngine engine)
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                var body = Encoding.UTF8.GetBytes(engine.GameEngineId.ToString());


                channel.BasicPublish(exchange: "gameEngine",
                                 routingKey: "gameEngine",
                                 basicProperties: null,
                                             body: body);
            }

        }
    }
}
