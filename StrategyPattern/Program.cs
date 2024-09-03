using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();

            MallardDuck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            RedheadDuck redhead = new RedheadDuck();
            redhead.Display();
            redhead.PerformQuack();
            redhead.PerformFly();

            DecoyDuck decoy = new DecoyDuck();
            decoy.Display();
            decoy.PerformQuack();
            decoy.PerformFly();

            RubberDuck rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformQuack();
            rubber.PerformFly();

        }
    }
}