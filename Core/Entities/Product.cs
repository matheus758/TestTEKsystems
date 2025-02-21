using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int BidProductId { get; set; }
        public Byte IsAvaliable { get; set; }

    }
}
