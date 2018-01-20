using System;

namespace SwitchingTV
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch tvButton = new ClickSwitch(new TV());

            tvButton.On();
            tvButton.Off();

            Switch radioButton = new ClickSwitch(new Radio());

            radioButton.On();
            radioButton.Off();

            Switch lampButton = new ClickSwitch(new Lamp());

            lampButton.On();
            lampButton.Off();

            Console.ReadKey();
        }
    }
}
