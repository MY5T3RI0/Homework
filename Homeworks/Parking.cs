using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homeworks
{
    class Parking : IEnumerable
    {
        private List<Car> _cars = new List<Car>();

        public int Count => _cars.Count;

        public const int MAX_CARS = 100;

        public Car this[string number]
        {
            get 
            {
                var car = _cars.FirstOrDefault(c => c.Number == number);
                return car;
            }
        }

        public Car this[int position]
        {
            get
            {
                if (position < _cars.Count)
                {
                    return _cars[position];
                }

                return null;
            }
            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
            }

        }


        public int AddCar(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Car is null");
            else
                _cars.Add(car);

            return _cars.Count - 1;

        }

        public void OutCar(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentNullException(nameof(number), "Number is null or empty");
            else
            {
                var car = _cars.First(c => c.Number == number);
                _cars.Remove(car);
            }

        }

        public IEnumerator GetEnumerator()
        {
            foreach (var car in _cars)
            {
                yield return car;
            }
        }

        public IEnumerable GetNumbers()
        {
            foreach (var car in _cars)
            {
                yield return car.Number;
            }
        }
    }
}
