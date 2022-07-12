﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        enum perechis
        {

            one,
            two = 6

        }

        public static object locker = new object();

        static void Main(string[] args)
        {
            #region collections

            //Console.ForegroundColor = ConsoleColor.Green;

            //string str = " ";
            //int i = 6;

            //str = Convert.ToString(i);
            //i = 0;
            //i = int.Parse(str);

            //int[] mas = new int[6];

            //mas[5] = 6;

            //List<int> spis = new List<int>();

            //spis.Add(0);
            //spis.Add(1);
            //spis.Add(2);
            //spis.Add(3);
            //spis.Add(4);
            //spis.Add(5);
            //spis.Add(6);

            #endregion

            #region operators
            //Console.WriteLine("Введите 3 числа");

            //int min = 999;
            //int j;
            //while (i != 3) {
            //    j = Convert.ToInt32(Console.ReadLine());
            //    if (j < min) {
            //        min = j;
            //    }
            //    i--;
            //}

            //Console.WriteLine(min);

            //switch (min%2) {
            //    case 1:
            //        Console.WriteLine("число нечетное");
            //        break;
            //    case 0:
            //        Console.WriteLine("число четное");
            //        break;
            //    default:
            //        Console.WriteLine("чтото не так");
            //        break;
            //}

            //Console.WriteLine(min < 100 ? "меньше 100" : "больше 100");

            //Console.WriteLine(str + i + mas[5] + spis[6] + Convert.ToInt32(perechis.two));

            #endregion

            #region cycls 
            //List<int> Col = new List<int>();

            //Console.WriteLine("введите 7 целых чисел");

            //for(int p = 0; p < 7; p++)
            //    Col.Add(Convert.ToInt32(Console.ReadLine()));

            //int sum = 0;

            //for (int p = 0; p < 7; p++)
            //    sum += Col[p];

            //int pp = 7;
            //int Raz = Col[1];

            //while (pp > 0)
            //{
            //    Raz -= Col[pp-1];
            //    pp--;
            //}

            //int ppp = 0;
            //int Proiz = 1;

            //while (ppp < 7)
            //{
            //    Proiz *= Col[ppp];
            //    ppp++;
            //}

            //foreach (int value in Col)
            //    Console.WriteLine(value);

            //Console.WriteLine($" Сумма = {sum}, Разность = {Raz}, Произведение = {Proiz}");

            #endregion

            #region file

            //Console.WriteLine("Введите номер автомобиля");

            //using (var sw = new StreamWriter("homework.txt", true))
            //{
            //    sw.WriteLine(Console.ReadLine());
            //}

            //using (var sr = new StreamReader("homework.txt"))
            //{
            //    Console.WriteLine("Регистрационный номер автомобиля: " + sr.ReadToEnd());
            //}

            //Console.WriteLine(Fibb(Convert.ToInt32(Console.ReadLine())));

            #endregion

            #region exception

            //try
            //{
            //    c1.Boost();
            //    Console.WriteLine("Ускорение активировано");
            //}
            //catch(MyException e)
            //{
            //    Console.WriteLine($"Автомобиль марки \u0022{c1.Mark}\u0022 сгенерировал ошибку \u0022{e.Message}\u0022");
            //}

            #endregion

            #region events

            //c1.Fuelling += Car_Fuelling;
            //c1.ContinueRacing += Car_ContinueRacing;

            //c1.Fuel = 10;
            //c1.FuelCheck(c1);

            //c1.Fuel = 3;
            //c1.FuelCheck(c1);

            #endregion

            #region methods

            //Console.WriteLine("Обычная скорость = " + c1.MaxSpeed);

            //Console.WriteLine("Увеличенная скорость = " + c1.MaxSpeed);

            #endregion

            #region operators

            //Console.WriteLine("Общая вместимость = " + (c1+c2));

            #endregion

            #region generic

            //var paint = new Tuning<Car>();
            //paint.NewColor(c1, "Blue");

            //Console.WriteLine("Новый цвет машины: " + c1.Color);

            //Console.WriteLine("Тип транспорта: " + c1.Type);

            #endregion

            #region constructor

            Bycicle b = new Bycicle("Land", "Yellow", 30);

            Car c1 = new Car("Land", "White", 120, "v6", 5);
            c1.Mark = "Ford";

            Car c2 = new Car("Land", "Red", 150, "v12", 10);

            #endregion

            #region async

            //var result = GetNumbersAsync(3000);

            //Random rnd = new Random();

            //for (int i = 0; i < 30000; i++)
            //{
            //    char c = Convert.ToChar(rnd.Next(65, 90));

            //    int j = rnd.Next(100, 999);

            //    string number = "";

            //    number += c + Convert.ToString(j) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90))) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90)));

            //    Console.WriteLine(number);
            //}

            //Console.WriteLine(result.Result);

            #endregion

            #region Thread

            //Thread thread = new Thread(new ParameterizedThreadStart(DoWork));
            //thread.Priority = ThreadPriority.Highest;
            //thread.Start(3000);

            //int j = 0;
            //for (int i = 0; i < 3000; i++)
            //{
            //    Console.WriteLine("Main");
            //} 

            #endregion

            #region TCP
            //const string ip = "127.0.0.1";
            //const int port = 8080;

            //var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //tcpSocket.Bind(tcpEndPoint);
            //tcpSocket.Listen(5);

            //while (true)
            //{
            //    var listener = tcpSocket.Accept();
            //    var buffer = new byte[256];
            //    var size = 0;
            //    var data = new StringBuilder();

            //    do
            //    {
            //        size = listener.Receive(buffer);
            //        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
            //    }
            //    while (listener.Available > 0);

            //    Console.WriteLine(data); 

            //    listener.Send(Encoding.UTF8.GetBytes("Успех"));

            //    listener.Shutdown(SocketShutdown.Both);
            //    listener.Close();
            //}
            #endregion

            

            Console.ReadLine();

        }

        static async Task<bool> GetNumbersAsync(int max)
        {
            var result = await Task.Run(() => GetNumbers(max));
            return result;
        }

        static void DoWork(object max)
        {
            lock (locker)
            {
                for (int i = 0; i < (int)max; i++)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }

        static bool GetNumbers(int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < max; i++)
            {
                char c = Convert.ToChar(rnd.Next(65, 90));

                int j = rnd.Next(100, 999);

                string number = "";

                number += c + Convert.ToString(j) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90))) + Convert.ToString(Convert.ToChar(rnd.Next(65, 90)));

                using (var sw = new StreamWriter("numbers.txt", false, Encoding.UTF8))
                {
                    sw.WriteLine(number);
                }
            }

            Console.WriteLine("Запись завершена");

            return true;
        }

        private static void Car_ContinueRacing(int volume)
        {
            Console.WriteLine($"Едем дальше, в баке еще {volume} литров");
        }

        private static void Car_Fuelling()
        {
            Console.WriteLine("Едем на заправку");
        }

        static int Fibb(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Fibb(n - 2) + Fibb(n - 1);

        }

    }
}