using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class ClassImplementationFirst : IIntefaceEncapsulation
    {
        public void DoMethodOne()
        {
            throw new NotImplementedException();
        }

        public void DoMethodTwo()
        {
            throw new NotImplementedException();
        }
    }
    class ClassImplementationSecond : IIntefaceEncapsulation
    {
        public void DoMethodOne()
        {
            throw new NotImplementedException();
        }

        public void DoMethodTwo()
        {
            throw new NotImplementedException();
        }
    }
}
