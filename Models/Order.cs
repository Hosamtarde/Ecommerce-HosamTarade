using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Customer customer { get; set; }

        public DateTime crateAt { get; set; }

        public DateTime updateAt { get; set; }

        public List<Product> products { get; set; }
        
        public totalPay()
        {
            foreach (var item in products)
            {
                totalToPay += item.price;
                Console.WriteLine($"{++i}.Product with name {item.Name} with Id {item.Id} with price {item.price} ");
            }
            Console.WriteLine($"Total Price : {totalToPay}");
            Console.WriteLine($"Your dicount : {DisCount.getdiscount(customer.type)}");
            Console.WriteLine($"your final  Total after discount is : {totalToPay - totalToPay * DisCount.getdiscount(customer.type)}");
        }

        public void getBill()
        {
            Console.WriteLine($"the Bill for Customer {customer.Name}   : ");
            int i = 0;
            double totalToPay = 0;

            totalToPay();

        }

    }
}
