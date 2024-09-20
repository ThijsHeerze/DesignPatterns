using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.Size = Beverages.Size.TALL;
            PrintBeverage(espresso);

            Beverage doppio = new Doppio();
            doppio.Size = Beverages.Size.VENDI;
            doppio = new Espresso(doppio);
            doppio.Size = Beverages.Size.VENDI;
            doppio = new Espresso(doppio);
            doppio.Size = Beverages.Size.VENDI;
            PrintBeverage(doppio);

            Beverage lungo = new Lungo();
            lungo.Size = Beverages.Size.TALL;
            lungo = new Espresso(lungo);
            lungo.Size = Beverages.Size.TALL;
            lungo = new Water(lungo);
            lungo.Size = Beverages.Size.TALL;
            PrintBeverage(lungo);

            Beverage macchiato = new Macchiato();
            macchiato.Size = Beverages.Size.TALL;
            macchiato = new Espresso(macchiato);
            macchiato.Size = Beverages.Size.TALL;
            macchiato = new MilkFoam(macchiato);
            macchiato.Size = Beverages.Size.TALL;
            PrintBeverage(macchiato);

            Beverage corretta = new Corretta();
            corretta.Size = Beverages.Size.TALL;
            corretta = new Espresso(corretta);
            corretta.Size = Beverages.Size.TALL;
            corretta = new Liqour(corretta);
            corretta.Size = Beverages.Size.TALL;
            PrintBeverage(corretta);

            Beverage conPanna = new ConPanna();
            conPanna.Size = Beverages.Size.VENDI;
            conPanna = new Espresso(conPanna);
            conPanna.Size = Beverages.Size.VENDI;
            conPanna = new Whip(conPanna);
            conPanna.Size = Beverages.Size.VENDI;
            PrintBeverage(conPanna);

            Beverage cappucinno = new Cappucinno();
            cappucinno.Size = Beverages.Size.TALL;
            cappucinno = new Water(cappucinno);
            cappucinno.Size = Beverages.Size.TALL;
            cappucinno = new Water(cappucinno);
            cappucinno.Size = Beverages.Size.TALL;
            PrintBeverage(cappucinno);

            Beverage americano = new Americano();
            americano.Size = Beverages.Size.TALL;
            americano = new Espresso(americano);
            americano.Size = Beverages.Size.TALL;
            americano = new Water(americano);
            americano.Size = Beverages.Size.TALL;
            americano = new Water(americano);
            americano.Size = Beverages.Size.TALL;
            PrintBeverage(americano);

            Beverage caffeLatte = new CafféLatte();
            caffeLatte.Size = Beverages.Size.TALL;
            caffeLatte = new Espresso(caffeLatte);
            caffeLatte.Size = Beverages.Size.TALL;
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte.Size = Beverages.Size.TALL;
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte.Size = Beverages.Size.TALL;
            caffeLatte = new MilkFoam(caffeLatte);
            caffeLatte.Size = Beverages.Size.TALL;
            PrintBeverage(caffeLatte);

            Beverage flatWhite = new FlatWhite();
            flatWhite.Size = Beverages.Size.TALL;
            flatWhite = new Espresso(flatWhite);
            flatWhite.Size = Beverages.Size.TALL;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite.Size = Beverages.Size.TALL;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite.Size = Beverages.Size.TALL;
            PrintBeverage(flatWhite);

            Beverage romana = new Romana();
            romana.Size = Beverages.Size.VENDI;
            romana = new Espresso(romana);
            romana.Size = Beverages.Size.VENDI;
            romana = new Lemon(romana);
            romana.Size = Beverages.Size.VENDI;
            PrintBeverage(romana);

            Beverage morocchino = new Morocchino();
            morocchino.Size = Beverages.Size.TALL;
            morocchino = new Espresso(morocchino);
            morocchino.Size = Beverages.Size.TALL;
            morocchino = new Chocolate(morocchino);
            morocchino.Size = Beverages.Size.TALL;
            morocchino = new MilkFoam(morocchino);
            morocchino.Size = Beverages.Size.TALL;
            PrintBeverage(morocchino);

            Beverage mocha = new Mocha();
            mocha.Size = Beverages.Size.TALL;
            mocha = new Espresso(mocha);
            mocha.Size = Beverages.Size.TALL;
            mocha = new Chocolate(mocha);
            mocha.Size = Beverages.Size.TALL;
            mocha = new SteamedMilk(mocha);
            mocha.Size = Beverages.Size.TALL;
            mocha = new Whip(mocha);
            mocha.Size = Beverages.Size.TALL;
            PrintBeverage(mocha);

            Beverage bicerin = new Bicerin();
            bicerin.Size = Beverages.Size.TALL;
            bicerin = new Espresso(bicerin);
            bicerin.Size = Beverages.Size.TALL;
            bicerin = new BlackChocolate(bicerin);
            bicerin.Size = Beverages.Size.TALL;
            bicerin = new WhiteChocolate(bicerin);
            bicerin.Size = Beverages.Size.TALL;
            bicerin = new Whip(bicerin);
            bicerin.Size = Beverages.Size.TALL;
            PrintBeverage(bicerin);

            Beverage breve = new Breve();
            breve.Size = Beverages.Size.TALL;
            breve = new Espresso(breve);
            breve.Size = Beverages.Size.TALL;
            breve = new BlackChocolate(breve);
            breve.Size = Beverages.Size.TALL;
            breve = new WhiteChocolate(breve);
            breve.Size = Beverages.Size.TALL;
            breve = new Whip(breve);
            breve.Size = Beverages.Size.TALL;
            PrintBeverage(breve);

            Beverage rafCoffee = new RafCoffee();
            rafCoffee.Size = Beverages.Size.TALL;
            rafCoffee = new Espresso(rafCoffee);
            rafCoffee.Size = Beverages.Size.TALL;
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee.Size = Beverages.Size.TALL;
            rafCoffee = new Cream(rafCoffee);
            rafCoffee.Size = Beverages.Size.TALL;
            PrintBeverage(rafCoffee);

            Beverage meadRaf = new MeadRaf();
            meadRaf.Size = Beverages.Size.TALL;
            meadRaf = new Espresso(meadRaf);
            meadRaf.Size = Beverages.Size.TALL;
            meadRaf = new Honey(meadRaf);
            meadRaf.Size = Beverages.Size.TALL;
            meadRaf = new Cream(meadRaf);
            meadRaf.Size = Beverages.Size.TALL;
            PrintBeverage(meadRaf);

            Beverage galao = new Galao();
            galao.Size = Beverages.Size.TALL;
            galao = new Espresso(galao);
            galao.Size = Beverages.Size.TALL;
            galao = new MilkFoam(galao);
            galao.Size = Beverages.Size.TALL;
            galao = new MilkFoam(galao);
            galao.Size = Beverages.Size.TALL;
            PrintBeverage(galao);

            Beverage caffeAffogato = new CafféAffogato();
            caffeAffogato.Size = Beverages.Size.TALL;
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato.Size = Beverages.Size.TALL;
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato.Size = Beverages.Size.TALL;
            caffeAffogato = new IceCream(caffeAffogato);
            caffeAffogato.Size = Beverages.Size.TALL;
            PrintBeverage(caffeAffogato);

            Beverage viennaCoffee = new ViennaCoffee();
            viennaCoffee.Size = Beverages.Size.TALL;
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee.Size = Beverages.Size.TALL;
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee.Size = Beverages.Size.TALL;
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee.Size = Beverages.Size.TALL;
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee.Size = Beverages.Size.TALL;
            PrintBeverage(viennaCoffee);

            Beverage glace = new Glace();
            glace.Size = Beverages.Size.TALL;
            glace = new Espresso(glace);
            glace.Size = Beverages.Size.TALL;
            glace = new IceCream(glace);
            glace.Size = Beverages.Size.TALL;
            PrintBeverage(glace);

            Beverage chocolateMilk = new ChocolateMilk();
            chocolateMilk.Size = Beverages.Size.GRANDE;
            chocolateMilk = new Chocolate(chocolateMilk);
            chocolateMilk.Size = Beverages.Size.GRANDE;
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk.Size = Beverages.Size.GRANDE;
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk.Size = Beverages.Size.GRANDE;
            PrintBeverage(chocolateMilk);

            Beverage demiCreme = new DemiCréme();
            demiCreme.Size = Beverages.Size.TALL;
            demiCreme = new Espresso(demiCreme);
            demiCreme.Size = Beverages.Size.TALL;
            demiCreme = new Espresso(demiCreme);
            demiCreme.Size = Beverages.Size.TALL;
            demiCreme = new Cream(demiCreme);
            demiCreme.Size = Beverages.Size.TALL;
            demiCreme = new Cream(demiCreme);
            demiCreme.Size = Beverages.Size.TALL;
            PrintBeverage(demiCreme);

            Beverage latteMacchiato = new LatteMacchiato();
            latteMacchiato.Size = Beverages.Size.TALL;
            latteMacchiato = new Espresso(latteMacchiato);
            latteMacchiato.Size = Beverages.Size.TALL;
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato.Size = Beverages.Size.TALL;
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato.Size = Beverages.Size.TALL;
            latteMacchiato = new MilkFoam(latteMacchiato);
            latteMacchiato.Size = Beverages.Size.TALL;
            PrintBeverage(latteMacchiato);

            Beverage freddo = new Freddo();
            freddo.Size = Beverages.Size.TALL;
            freddo = new Espresso(freddo);
            freddo.Size = Beverages.Size.TALL;
            freddo = new Liqour(freddo);
            freddo.Size = Beverages.Size.TALL;
            freddo = new Ice(freddo);
            freddo.Size = Beverages.Size.TALL;
            PrintBeverage(freddo);

            Beverage frappuccino = new Frappuccino();
            frappuccino.Size = Beverages.Size.GRANDE;
            frappuccino = new Espresso(frappuccino);
            frappuccino.Size = Beverages.Size.GRANDE;
            frappuccino = new Ice(frappuccino);
            frappuccino.Size = Beverages.Size.GRANDE;
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino.Size = Beverages.Size.GRANDE;
            frappuccino = new Whip(frappuccino);
            frappuccino.Size = Beverages.Size.GRANDE;
            PrintBeverage(frappuccino);

            Beverage caramelFrappuccino = new CaramelFrappuccino();
            caramelFrappuccino.Size = Beverages.Size.VENDI;
            caramelFrappuccino = new Espresso(caramelFrappuccino);
            caramelFrappuccino.Size = Beverages.Size.VENDI;
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino.Size = Beverages.Size.VENDI;
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino.Size = Beverages.Size.VENDI;
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino.Size = Beverages.Size.VENDI;
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            caramelFrappuccino.Size = Beverages.Size.VENDI;
            PrintBeverage(caramelFrappuccino);

            Beverage frappe = new Frappe();
            frappe.Size = Beverages.Size.TALL;
            frappe = new Espresso(frappe);
            frappe.Size = Beverages.Size.TALL;
            frappe = new SteamedMilk(frappe);
            frappe.Size = Beverages.Size.TALL;
            frappe = new SteamedMilk(frappe);
            frappe.Size = Beverages.Size.TALL;
            frappe = new IceCream(frappe);
            frappe.Size = Beverages.Size.TALL;
            PrintBeverage(frappe);

            Beverage irishCoffee = new IrishCoffee();
            irishCoffee.Size = Beverages.Size.TALL;
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee.Size = Beverages.Size.TALL;
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee.Size = Beverages.Size.TALL;
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee.Size = Beverages.Size.TALL;
            irishCoffee = new Whip(irishCoffee);
            irishCoffee.Size = Beverages.Size.TALL;
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"Beverage: {beverage.GetDescription()}, Size: {beverage.Size}, Cost: {beverage.cost():C}");
        }
    }
}