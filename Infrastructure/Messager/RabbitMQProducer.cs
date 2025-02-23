using Application.Interface.Messager;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Infrastructure.Messager
{
    public class RabbitMQProducer : IRabbitMQProducer
    {
        public async void SendProductMessage<T>(T message, string queue)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: queue, durable: false, exclusive: false, autoDelete: false,
    arguments: null);

            var messageJson = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(messageJson);

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "bid", body: body);
            Console.WriteLine($" [x] Sent {message}");
        }
    }
}