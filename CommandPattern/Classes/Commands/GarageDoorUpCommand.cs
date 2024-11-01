using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class GarageDoorUpCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
            garageDoor.LightOn();
        }

        public void Undo()
        {
            garageDoor.Down();
            garageDoor.LightOff();
        }
    }
}
