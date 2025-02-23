using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Bid
    {
        public int Id { get; set; }
 
        public Decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

    }
}
