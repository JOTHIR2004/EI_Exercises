namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Decorator Pattern Demo ===");

            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

            // Add Milk
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

            // Add Sugar
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

            Console.ReadKey();
        }
    }
}
