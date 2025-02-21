using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Messager
{
    public interface IRabbitMQReceiver
    {
        public void ReceiveMessage<T>( string queue);
    }
}
