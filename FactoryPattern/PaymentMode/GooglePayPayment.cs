using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PaymentMode
{
    public class GooglePayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Payment: ${amount} is Successful to Merchent by GooglePay");
        }
    }
}
