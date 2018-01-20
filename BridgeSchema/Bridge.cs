using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    abstract class Bridge
    {
        private IIntefaceEncapsulation interfaceencapsulation;

        public Bridge(IIntefaceEncapsulation interfaceencapsulation)
        {
            this.interfaceencapsulation = interfaceencapsulation;
        }

        public void DoMethodOne()
        {
            interfaceencapsulation.DoMethodOne();
        }

        public void DoMethodTwo()
        {
            interfaceencapsulation.DoMethodTwo();
        }
    }

    class BridgeImplementation : Bridge
    {
        public BridgeImplementation(IIntefaceEncapsulation interfaceencapsulation) : base(interfaceencapsulation) { }

        public void GetMethod()
        {
            DoMethodOne();
            DoMethodTwo();
        }
    }
}
