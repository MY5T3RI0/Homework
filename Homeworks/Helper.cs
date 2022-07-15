using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public static class Helper
    {
        public static int fact(this int number)
        {
            for (int i = number-1; i > 1; i--)
            {
                number *= i;
            }

            return number;
        }
    }
}
