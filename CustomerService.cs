using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Service
{
    internal class CustomerService
    {
        private readonly List<Customer> _customers;
        private readonly ProductService _ProductService;
        private readonly OrderService _OrderService;

        public CustomerService(ProductService productService, OrderService orderService)
        {
            _ProductService = productService;
            _OrderService = orderService;
            _customers = new List<Customer>();
        }

        public void conditionalCustomer()
        {
            char yn = char.Parse(Console.ReadLine());
            Customer customerr = new Customer();
            if (yn == 'y')
                customerr = Signup();
            else
                customerr = Signin();


            if (customerr == null)
            {
                Console.WriteLine("something went wrong please Try Again Later ");
                return;
            }
        }


        public void startShaping()
        {
            Console.WriteLine("Welcome To Prime Shop !!!!!!!!");
            Console.WriteLine("are you new customer (y , n) ?");
            

            conditionalCustomer();

            variable();
        }


        public void variable()
        {
            int maxPrice = 7;
            int choice = choose();
            var products = _ProductService.GetProducts(b => true);
        }


        int choose()
        {
            Console.WriteLine("Choose one\n ");
            Console.WriteLine("(1) find Product With Name \n");
            Console.WriteLine("(2) find Product With maximum price \n");
            Console.WriteLine("(3) find Product With minimum price \n");
            Console.WriteLine("(4) find All the product \n");
            Console.WriteLine("(5) Place Order \n");
            Console.WriteLine("(6) Exit \n");
            int choosenValue = int.Parse(Console.ReadLine());
            return choosenValue;
        }

        public void ifConditionSignIn()
        {
            Console.WriteLine("Please Enter Your Name ");
            string name = Console.ReadLine();

            if (customer != null && customer.Name.ToLower() == name.ToLower())
            {
                return customer;
            }
            return null;
        }

        public void addNameAndIdInSignup()
        {
            Console.WriteLine("Please Give us Your Name  ! ");
            string name = Console.ReadLine();
            Customer customer = new Customer();
            customer.Name = name;
            Console.WriteLine($"Your name : {name} \n your id : {customer.Id}");
            _customers.Add(customer);

        }

        Customer Signin()
        {
            Console.WriteLine("Please Enter Your Id");
            int id = int.Parse(Console.ReadLine());

            var customer = _customers.SingleOrDefault(x => x.Id == id , null);

            ifConditionSignIn();


        }


        Customer Signup()
        {
            addNameAndIdInSignup();
            return customer;

        }






    }
}

