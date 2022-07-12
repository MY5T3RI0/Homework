using System;

namespace Homeworks
{
    public class Car : Transport, ILand
    {
        public event Action Fuelling;
        public event Action<int> ContinueRacing;
        public Car(string type, string color, int maxSpeed, string engine, int capasity) : base(type, color, maxSpeed)
        {
            Type = type;
            Color = color;
            MaxSpeed = maxSpeed;
            Engine = engine;
            Capasity = capasity;
        }

        public string Engine { get; set; }
        public int Capasity { get; set; }
        public bool Nitro { get; set; } = false;
        public string Mark { get; set; }
        public int Fuel { get; set; }

        public void FuelCheck(Car car)
        {
            if (car.Fuel < 5)
                Fuelling?.Invoke();
            else
                ContinueRacing?.Invoke(car.Fuel);

        }

        public int Drive(int distanse)
        {
            return distanse / 100;          
        }

        public void Boost() 
        {

            if (Nitro == false)
            {
                MaxSpeed += 30;
                Nitro = true;
            }
            else
                throw new MyException(this, "Ускорение уже активировано");
            
        }

        public static int operator + (Car firstCar, Car secondCar)
        { 
            return firstCar.Capasity + secondCar.Capasity;
        }
    }
}
