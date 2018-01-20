using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchingTV
{
    abstract class Switch
    {
        protected IDevice device;

        public Switch(IDevice device)
        {
            this.device = device;
        }

        public abstract void On();

        public abstract void Off();
    }

    class ClickSwitch : Switch
    {
        public ClickSwitch(IDevice device) : base(device)
        { }

        public override void On()
        {
            device.On();
        }

        public override void Off()
        {
            device.Off();
        }
    }
}
