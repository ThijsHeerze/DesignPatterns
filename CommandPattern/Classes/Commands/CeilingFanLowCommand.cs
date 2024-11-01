using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.High();
        }

        public void Undo()
        {
            // Restore fan to previous speed
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
                case 0:
                    ceilingFan.Off();
                    break;
            }
        }
    }
}
