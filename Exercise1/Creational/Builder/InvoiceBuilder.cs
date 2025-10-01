using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InvoiceBuilder
    {
        private readonly Invoice _invoice = new Invoice();

        public InvoiceBuilder SetHeader(string header)
        {
            _invoice.Header = header;
            return this; // Fluent interface
        }

        public InvoiceBuilder AddItem(string name, int quantity, double price)
        {
            _invoice.Items.Add($"{name} x{quantity} @ {price}");
            return this;
        }

        public InvoiceBuilder SetDiscount(double discount)
        {
            _invoice.Discount = discount;
            return this;
        }

        public InvoiceBuilder SetFooter(string footer)
        {
            _invoice.Footer = footer;
            return this;
        }

        public Invoice Build()
        {
            return _invoice; // Return the final product
        }
    }
}
