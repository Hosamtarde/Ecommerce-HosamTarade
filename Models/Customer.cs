using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public enum CustomerType {Normal , Vip }
    internal class Customer : User
    {
        public static int idcount = 1;
        public Customer(CustomerType customerType = CustomerType.Normal) 
        {
            type = customerType;
            createAt = DateTime.Now;
            idcount *= 3352;
            idcount %= 1800;
            Id= idcount;
            orders = new List<Order>();
        }
        public string visaInfo { get; set; }    
        
        DateTime createAt { get; set; }

        List<Order> orders { get; set; }

        public CustomerType type { get; set; }

        public override Role access()
        {
            return Role.Customer;
        }
    }
}
