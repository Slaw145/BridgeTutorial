using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchingTV
{
    class Radio : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the radio was turned off");
        }

        public void On()
        {
            Console.WriteLine("the radio was turned on");
        }
    }
}
