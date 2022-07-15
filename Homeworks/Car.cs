using System;
using System.Collections.Generic;

namespace Homeworks
{
    public class Car : Transport, ILand
    {
        public event Action Fuelling;
        public event Action<int> ContinueRacing;

        public List<string> Numbers = new List<string>();

        public Car(string type, string color, int maxSpeed, string engine, int capasity) : base(type, color, maxSpeed)
        {
            Type = type;
            Color = color;
            MaxSpeed = maxSpeed;
            Engine = engine;
            Capasity = capasity;
        }

        Random rand = new Random();
        public Car(string mark)
        {
            Mark = mark;
            Number = Numbers[rand.Next(1, 500)];
        }

        public Car(string mark, string number)
        {
            Mark = mark;
            Number = number;
        }

        public string Engine { get; set; }
        public int Capasity { get; set; }
        public bool Nitro { get; set; } = false;
        public string Mark { get; set; }
        public int Fuel { get; set; }
        public string Number { get; set; }

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

        public void GetNumbers(int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < max; i++)
            {
                char c = Convert.ToChar(rnd.Next(65, 90));

                int j = rnd.Next(100, 999);

                string number = "";

                number += c + Convert.ToString(j) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90))) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90)));

                Numbers.Add(number);
            }
        }

        public static int operator + (Car firstCar, Car secondCar)
        { 
            return firstCar.Capasity + secondCar.Capasity;
        }

        public override string ToString()
        {
            return $"Автомобиль марки {Mark} регистрационный номер ({Number})";
        }
    }
}
