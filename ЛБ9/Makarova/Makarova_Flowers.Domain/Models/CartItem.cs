using Flowers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers.Domain.Models
{
    public class CartItem
    {
        public Flower Item { get; set; }
        public int Qty { get; set; }
    }
}
