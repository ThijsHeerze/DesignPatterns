﻿using SimpleCommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern.Classes.Commands
{
    internal class StereoOffCommand : Command
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }
        public void Undo()
        {
        }
    }
}
