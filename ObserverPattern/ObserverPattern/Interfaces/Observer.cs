﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    internal interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
}
