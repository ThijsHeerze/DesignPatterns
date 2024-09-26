using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double cost = baseBeverage.cost();
            switch (baseBeverage.Size)
            {
                case Beverages.Size.TALL:
                    cost += 0.10;
                    break;
                case Beverages.Size.GRANDE:
                    cost += 0.15;
                    break;
                case Beverages.Size.VENDI:
                    cost += 0.20;
                    break;
            }
            return cost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Whip";
        }
    }
}
