using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Medium();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case 3:
                    ceilingFan.High();
                    break;
                case 2:
                    ceilingFan.Medium();
                    break;
                case 1:
                    ceilingFan.Low();
                    break;
                default:
                    ceilingFan.Off();
                    break;
            }
        }
    }
}
