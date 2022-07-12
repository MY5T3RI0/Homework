using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    class MyException : ApplicationException
    {
        Car c;
        public MyException(Car c, string message) : base(message)
        {
            this.c = c;
        }
    }
}
