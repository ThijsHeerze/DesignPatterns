using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithRadioCommand : Command
    {
        Stereo stereo;
        int prevVolume;
        public StereoOnWithRadioCommand(Stereo stereo)
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
