using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Service
{
    internal class OrderService
    {
        private List<Order> orders;
        static int IdCount = 1;


        public OrderService()
        {
            orders = new List<Order>();
        }

        public AddOrder()
        {
            orders.Add(order);

            customer.orders.Add(order);
            foreach (Product x in products)
                x.quantity--;
            return order;
        }

        public Order PlaceOrder(Customer customer , List<Product> products )
        {
            Order order = new Order();
            IdCount *= 101010142;
            IdCount %= 223123212;
            order.Id = IdCount;
            order.customer = customer;
            order.products = products;
            order.crateAt = DateTime.Now;

            AddOrder();
        }


        public List<Order> GetOrders(Func<Order ,bool > fillter)
        {
            return orders.Where(fillter).ToList();
        }
    }
}
