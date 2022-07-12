using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Tuning<T>
        where T: Transport
    {

        public void NewColor(T transp, string color)
        {

            transp.Color = color;

        }

    }
}
