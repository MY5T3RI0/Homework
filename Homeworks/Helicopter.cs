using System;

namespace Homeworks
{
    public class Helicopter : Transport, IAir
    {
        public Helicopter(string type, string color, int maxSpeed) : base(type, color, maxSpeed)
        {
            Type = type;
            Color = color;
            MaxSpeed = maxSpeed;
        }       

        public string fuel { get; set; }

        public int Fly(int distanse)
        {
            return distanse / 300;
        }

    }
}
