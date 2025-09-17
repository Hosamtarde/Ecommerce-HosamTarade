using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Service
{
    internal class ProductService
    {
        List<Product> products;

        public ProductService()
        {
            products = new List<Product>();
        }


        public void addProduct(Product product)
        {
            if (product.quantity == 0)
            {
                Console.WriteLine("This product has no quantity to add ");
                return;
            }
            product = NewMethod(product);
            products.Add(product);
        }

        private static Product NewMethod(Product product)
        {
            product.CreatAt = DateTime.Now;
            return product;
        }

        public void removeProduct(int id )
        {
            products = products.Where(b => b.Id == id).ToList();
        }


        public List<Product> GetProducts(Func<Product, bool> fillter)
        {
            return products.Where(fillter).ToList();
        }

        public Product getProductById(int id) 
        {
            return products.SingleOrDefault(b => b.Id == id);
        }
    }
}
