﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen up");
        }
        public void Down() 
        {
            Console.WriteLine("Screen down");
        }
    }
}
