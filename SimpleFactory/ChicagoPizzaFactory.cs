namespace SimpleFactory
{
    internal class ChicagoPizzaFactory : SimplePizzaFactory
    {
        public virtual Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            // Safely compare strings with null check and case-insensitivity
            if (string.Equals(type, "cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (string.Equals(type, "pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (string.Equals(type, "clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (string.Equals(type, "veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }
}