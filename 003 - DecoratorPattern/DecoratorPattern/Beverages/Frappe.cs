﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Frappe : Beverage
    {
        public Frappe(Beverage beverage = null)
        {
            description = "Frappe";
            this.baseBeverage = beverage;

        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            double baseCost = 1.99;
            if (baseBeverage != null)
            {
                baseCost += baseBeverage.cost();
            }

            switch (baseBeverage?.Size ?? this.Size)
            {
                case Size.TALL:
                    baseCost += 0.10;
                    break;
                case Size.GRANDE:
                    baseCost += 0.15;
                    break;
                case Size.VENDI:
                    baseCost += 0.20;
                    break;
            }

            return baseCost;
        }
    }
}