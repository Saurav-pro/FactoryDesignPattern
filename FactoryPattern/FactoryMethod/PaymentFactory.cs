using FactoryPattern.PaymentMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class PaymentFactory
    {
        public static IPayment Payment(PaymentMethods paymentMethod)
        { 
            switch (paymentMethod) 
            {
                case PaymentMethods.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethods.GooglePay:
                    return new GooglePayPayment();
                case PaymentMethods.PayPal:
                    return new PayPalPayment();
                default: throw new NotSupportedException(
                    $"{paymentMethod} is not supported");
            }
        
        
        }
    }
}
