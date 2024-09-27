using System;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factories
{
    internal abstract class BeverageFactory
    {
        public abstract Beverage CreateBeverage(DrinkType type);
    }
}
