using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck redhead = new RedheadDuck();
            redhead.Display();
            redhead.PerformQuack();
            redhead.PerformFly();

            Duck decoy = new DecoyDuck();
            decoy.Display();
            decoy.PerformQuack();
            decoy.PerformFly();

            Duck rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformQuack();
            rubber.PerformFly();

            Duck robot = new RobotDuck();
            robot.Display();
            robot.PerformSwim();
        }
    }
}