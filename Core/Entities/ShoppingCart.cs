using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCardId { get; set; }

        public List<User>? User { get; set; }

        public List<Product>? Product { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }


    }
}
