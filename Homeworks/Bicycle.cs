using System;

namespace Homeworks
{
    public class Bycicle : Transport, ILand
    {
        public Bycicle(string type, string color, int maxSpeed) : base(type, color, maxSpeed)
        {
            Type = type;
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public int Wheels { get; set; }

        public int Drive(int distanse)
        {
            return distanse / 20;
        }
    }
}