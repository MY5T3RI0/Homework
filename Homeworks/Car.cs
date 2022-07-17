using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Homeworks
{
    [DataContract]
    public class Car : Transport, ILand
    {
        public event Action LowFuell;
        public event Action<int> FullFuel;
        public event EventHandler<int> ChargedFuell;

        public static List<string> marks = new List<string>()
        {
            new string("Kia"),
            new string("BMW"),
            new string("Ford"),
            new string("Honda"),
            new string("Hyundai")
        };

        public Car(string type, string color, int maxSpeed, string engine, int capasity) : base(type, color, maxSpeed)
        {
            Type = type;
            Color = color;
            MaxSpeed = maxSpeed;
            Engine = engine;
            Capasity = capasity;
        }

        [NonSerialized]
        private readonly Random rand = new Random();

        [Geo(10, 20)]
        public Car()
        {
            Mark = marks[rand.Next(0, 4)];
            List<string> numbers = Car_GetNumbers(100);
            Number = numbers[rand.Next(0, 99)];
        }

        public Car(string mark, string number)
        {
            Mark = mark;
            Number = number;
        }
        
        public string Engine { get; set; }
        public int Capasity { get; set; }
        public bool Nitro { get; set; } = false;
        [Geo(10, 20)]
        [DataMember]
        public string Mark { get; set; }
        public int Fuel { get; set; }
        [DataMember]
        public string Number { get; set; }

        public void FuelCheck(Car car)
        {
            if (car.Fuel == 30)
                ChargedFuell?.Invoke(this, car.Fuel);
            else if (car.Fuel < 5)
                LowFuell?.Invoke();
            else
                FullFuel?.Invoke(car.Fuel);

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

        public List<string> Car_GetNumbers(int max)
        {
            Random rnd = new Random();
            List<string> numbers = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                char c = Convert.ToChar(rnd.Next(65, 90));

                int j = rnd.Next(100, 999);

                string number = "";

                number += c + Convert.ToString(j) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90))) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90)));

                numbers.Add(number); 
            }

            return numbers;
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
