using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchingTV
{
    class Lamp : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the lamp was turned off");
        }

        public void On()
        {
            Console.WriteLine("the lamp was turned on");
        }
    }
}
