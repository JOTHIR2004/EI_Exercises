namespace Factory_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory Method Pattern Demo (School Fees Payment) ===\n");

            // Create payment objects dynamically using the factory
            IPayment payment1 = PaymentFactory.GetPaymentMethod("CreditCard");
            IPayment payment2 = PaymentFactory.GetPaymentMethod("PayPal");
            IPayment payment3 = PaymentFactory.GetPaymentMethod("BankTransfer");

            // Pay school fees
            payment1.Pay(5000);
            payment2.Pay(7500);
            payment3.Pay(10000);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
