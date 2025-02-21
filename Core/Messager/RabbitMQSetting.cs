
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace Core.Messager
{
        public class RabbitMQSetting
        {
            public string? HostName { get; set; }
            public string? UserName { get; set; }
            public string? Password { get; set; }
        }

        //RabbitMQ Queue name
        public static class RabbitMQQueues
        {
            public const string OrderValidationQueue = "orderValidationQueue";
            public const string AnotherQueue = "anotherQueue";
            public const string ThirdQueue = "thirdQueue";
        }
    }