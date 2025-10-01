namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Builder Pattern Demo ===");

            var invoice = new InvoiceBuilder()
                .SetHeader("School Fee Invoice")
                .AddItem("Tuition Fee", 1, 5000)
                .AddItem("Books", 3, 300)
                .SetDiscount(500)
                .SetFooter("Thank you for your payment!")
                .Build();

            invoice.Print();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
