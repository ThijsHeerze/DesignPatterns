using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class GarageDoorDownCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
            garageDoor.LightOff();
        }

        public void Undo()
        {
            garageDoor.Up();
            garageDoor.LightOn();
        }
    }
}
