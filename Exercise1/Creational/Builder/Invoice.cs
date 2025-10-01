using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Invoice
    {
        public string Header { get; set; }
        public List<string> Items { get; set; } = new();
        public double Discount { get; set; }
        public string Footer { get; set; }

        // Display invoice
        public void Print()
        {
            Console.WriteLine("===== Invoice =====");
            if (!string.IsNullOrEmpty(Header)) Console.WriteLine(Header);
            foreach (var item in Items) Console.WriteLine(item);
            if (Discount > 0) Console.WriteLine($"Discount: {Discount}");
            if (!string.IsNullOrEmpty(Footer)) Console.WriteLine(Footer);
            Console.WriteLine("===================");
        }
    }
}
