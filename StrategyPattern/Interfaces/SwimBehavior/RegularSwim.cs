﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class RegularSwim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
