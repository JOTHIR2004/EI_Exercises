using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class PaymentFactory
    {
        public static IPayment GetPaymentMethod(string method)
        {
            return method switch
            {
                "CreditCard" => new CreditCardPayment(),
                "PayPal" => new PayPalPayment(),
                "BankTransfer" => new BankTransferPayment(),
                _ => throw new ArgumentException("Invalid payment method")
            };
        }
    }
}
