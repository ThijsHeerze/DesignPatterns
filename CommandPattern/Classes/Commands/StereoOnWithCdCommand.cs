using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithCdCommand : Command
    {
        Stereo stereo;
        int prevVolume;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            prevVolume = 0;
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(10);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
