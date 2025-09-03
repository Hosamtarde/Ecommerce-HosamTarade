using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    interface Idiscount
    {
        public  double getdiscount();
    }

    public class VipDiscount :Idiscount {
        public double getdiscount()
        {
            return 0.30;
        }
    }
    public class NormalDiscount : Idiscount
    {
        public double getdiscount()
        {
            return 0.20;
        }
    }
    internal class DisCount
    {
        public static double getdiscount(CustomerType customerType)
        {
            if (customerType == CustomerType.Normal)
                return 0.20;
            else
                return 0.30;
        }
    }
}
