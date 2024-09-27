using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    public enum DrinkType
    {
        ESPRESSO,
        DOPPIO,
        LUNGO,
        MACCHIATO,
        CORRETTA,
        CON_PANNA,
        CAPPUCCINO,
        AMERICANO,
        CAFFE_LATTE,
        FLAT_WHITE,
        ROMANA,
        MOROCCHINO,
        MOCHA,
        BICERIN,
        BREVE,
        RAF_COFFEE,
        MEAD_RAF,
        GALAO,
        CAFFE_AFFOGATO,
        VIENNA_COFFEE,
        GLACE,
        CHOCOLATE_MILK,
        DEMI_CREME,
        LATTE_MACCHIATO,
        FREDDO,
        FRAPPUCCINO,
        CARAMEL_FRAPPUCCINO,
        FRAPPE,
        IRISH_COFFEE,
    }

    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
