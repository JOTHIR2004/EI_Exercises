using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual string GetDescription() => coffee.GetDescription();

        public virtual double GetCost() => coffee.GetCost();
    }
}
