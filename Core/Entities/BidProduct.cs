using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BidProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BidId { get; set; }
    }
}
