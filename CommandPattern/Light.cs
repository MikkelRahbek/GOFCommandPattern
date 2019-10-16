﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Light
    {
        public void On()
        {
            Console.WriteLine("Light is turned On");
        }

        public void Off()
        {
            Console.WriteLine("Light is turned Off");
        }
    }
}
