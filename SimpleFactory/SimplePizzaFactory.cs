using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class SimplePizzaFactory
    {
        public virtual Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            // Safely compare the type string with a null check and case-insensitivity
            if (string.Equals(type, "cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CheesePizza();
            }
            else if (string.Equals(type, "pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new PepperoniPizza();
            }
            else if (string.Equals(type, "clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ClamPizza();
            }
            else if (string.Equals(type, "veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
