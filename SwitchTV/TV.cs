using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchingTV
{
    class TV : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the TV was turned off");
        }

        public void On()
        {
            Console.WriteLine("the TV was turned on");
        }
    }
}
