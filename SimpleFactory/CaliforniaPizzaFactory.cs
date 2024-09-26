namespace SimpleFactory
{
    internal class CaliforniaPizzaFactory : SimplePizzaFactory
    {
        public virtual Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            // Check for null and use string comparison with a default empty string if type is null
            if (string.Equals(type, "cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CaliforniaStyleCheesePizza();
            }
            else if (string.Equals(type, "pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CaliforniaStylePepperoniPizza();
            }
            else if (string.Equals(type, "clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CaliforniaStyleClamPizza();
            }
            else if (string.Equals(type, "veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CaliforniaStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
