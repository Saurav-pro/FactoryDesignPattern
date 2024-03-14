using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PaymentMode
{
    public class PayPalPayment : IPayment
    {
        void IPayment.Pay(double amount)
        {
            Console.WriteLine($"Payment: ${amount} is Successful to Merchent by PayPal");
        }
    }
}
