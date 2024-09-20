using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Sugar : CondimentDecorator
    {
        public Sugar(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double baseCost = 0.00;
            if (baseBeverage != null)
            {
                baseCost += baseBeverage.cost();
            }

            switch (baseBeverage?.Size ?? this.Size)
            {
                case Beverages.Size.TALL:
                    baseCost += 0.10;
                    break;
                case Beverages.Size.GRANDE:
                    baseCost += 0.15;
                    break;
                case Beverages.Size.VENDI:
                    baseCost += 0.20;
                    break;
            }

            return baseCost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Sugar";
        }
    }
}
