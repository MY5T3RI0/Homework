using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor | AttributeTargets.Class)]
    class GeoAttribute : Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute() { }

        public GeoAttribute(int x, int y)
        {
            // Проверка входных данных.

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }
}
