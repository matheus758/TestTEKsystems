using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Infrastructure.Messager
{
    public class RabbitMQReceiver
    {
        public async void ReceiveMessage<T>(T message, string queue)
        {

            //var consumer = new EventingBasicConsumer(channel);
            //consumer.Received += async (ch, ea) =>
            //        {
            //            var body = ea.Body.ToArray();
            //            // copy or deserialise the payload
            //            // and process the message
            //            // ...
            //            await channel.BasicAckAsync(ea.DeliveryTag, false);
            //        };
            //// this consumer tag identifies the subscription
            //// when it has to be cancelled
            //string consumerTag = await channel.BasicConsumeAsync(queueName, false, consumer);
        }
}
}
