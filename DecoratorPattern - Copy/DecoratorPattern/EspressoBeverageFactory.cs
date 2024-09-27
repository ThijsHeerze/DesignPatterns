using System;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factories
{
    internal class EspressoBeverageFactory : BeverageFactory
    {
        public override Beverage CreateBeverage(DrinkType type)
        {
            switch (type)
            {
                case DrinkType.ESPRESSO:
                    return new Espresso();
                case DrinkType.DOPPIO:
                    return new Doppio();
                case DrinkType.LUNGO:
                    return new Lungo();
                case DrinkType.MACCHIATO:
                    return new Macchiato();
                case DrinkType.CORRETTA:
                    return new Corretta();
                case DrinkType.CON_PANNA:
                    return new ConPanna();
                case DrinkType.CAPPUCCINO:
                    return new Cappuccino();
                case DrinkType.AMERICANO:
                    return new Americano();
                case DrinkType.CAFFE_LATTE:
                    return new CafféLatte();
                case DrinkType.FLAT_WHITE:
                    return new FlatWhite();
                case DrinkType.ROMANA:
                    return new Romana();
                case DrinkType.MOROCCHINO:
                    return new Morocchino();
                case DrinkType.MOCHA:
                    return new Mocha();
                case DrinkType.BICERIN:
                    return new Bicerin();
                case DrinkType.BREVE:
                    return new Breve();
                case DrinkType.RAF_COFFEE:
                    return new RafCoffee();
                case DrinkType.MEAD_RAF:
                    return new MeadRaf();
                case DrinkType.GALAO:
                    return new Galao();
                case DrinkType.CAFFE_AFFOGATO:
                    return new CafféAffogato();
                case DrinkType.VIENNA_COFFEE:
                    return new ViennaCoffee();
                case DrinkType.GLACE:
                    return new Glace();
                case DrinkType.CHOCOLATE_MILK:
                    return new ChocolateMilk();
                case DrinkType.DEMI_CREME:
                    return new DemiCréme();
                case DrinkType.LATTE_MACCHIATO:
                    return new LatteMacchiato();
                case DrinkType.FREDDO:
                    return new Freddo();
                case DrinkType.FRAPPUCCINO:
                    return new Frappuccino();
                case DrinkType.CARAMEL_FRAPPUCCINO:
                    return new CaramelFrappuccino();
                case DrinkType.FRAPPE:
                    return new Frappe();
                case DrinkType.IRISH_COFFEE:
                    return new IrishCoffee();

                default:
                    throw new ArgumentException("Onbekende dranktype voor deze factory");
            }
        }
    }
}
