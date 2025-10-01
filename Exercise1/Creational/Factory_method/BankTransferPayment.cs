using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class BankTransferPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
    }
}
