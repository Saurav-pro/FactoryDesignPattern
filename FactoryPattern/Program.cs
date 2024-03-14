using FactoryPattern;
using FactoryPattern.FactoryMethod;

IPayment payment = PaymentFactory.Payment(PaymentMethods.GooglePay);

payment.Pay(120);