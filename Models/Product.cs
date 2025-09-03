using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    internal class Product
    {
        public static int idcount = 0; 
        public Product(string Name ,double price , int quantity ) { 
            this.Name = Name;
            this.price = price;
            this.quantity = quantity;
            this.CreatAt = DateTime.Now;
            Id = ++idcount;
        }

        public DateTime CreatAt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public int quantity { get; set; }
        public string Description { get; set; }

        public string category { get; set; }
        public double price { get; set; }

    }
}
