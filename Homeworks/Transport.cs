using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Transport : IMoving
    {
        public Transport(string type, string color, int maxSpeed)
        {
            Type = type;
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public Transport()
        {
            
        }

        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                {
                    _type = value;
                }
            }
        }
        public string Color { get; set; }

        private int _maxSpeed;
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
            }
        }

        public int Move(int distanse)
        {
            throw new NotImplementedException();
        }
    }
}
