using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RekikPieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pie Pie { get; set; }
        public int Count { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
