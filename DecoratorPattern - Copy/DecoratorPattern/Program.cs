using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory espressoFactory = new EspressoBeverageFactory();

            Beverage americano = espressoFactory.CreateBeverage(DrinkType.AMERICANO);
            americano.Size = Size.GRANDE;

            PrintBeverage(americano);

            Beverage cappuccino = espressoFactory.CreateBeverage(DrinkType.CAPPUCCINO);
            cappuccino.Size = Size.VENDI;

            PrintBeverage(cappuccino);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()}, Size: {beverage.Size}, Cost: {beverage.cost():C}");
        }
    }
}