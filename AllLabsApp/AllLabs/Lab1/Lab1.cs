using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs
{
    internal class Lab1 : ILabs
    {
        /// <summary>
        /// Метод демоснтрации лабораторной
        /// </summary>
        public void Demo()
        {
            Console.WriteLine();
            Console.WriteLine("Задание №1: ");
            Console.WriteLine();
            double result = Math.Sqrt(Math.Pow(2, 2) - Math.Pow(3, 3) / Math.Sqrt(Math.Pow(3, 4) - Math.Pow(2, 4)) + Math.Abs(Math.Pow(3, 5) - Math.Pow(15, 2.5)));
            Console.WriteLine("Ответ = " + result);

            Console.WriteLine();
            Console.WriteLine("Задание №2: ");
            Console.WriteLine();
            Console.Write("Введите значение a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b = ");
            int y = int.Parse(Console.ReadLine());
            double z = (Math.Pow(x, 2) + Math.Pow(y, 1 / 3)) / (x + y);
            Console.Write("c = " + z);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задание №3: ");
            Console.WriteLine();
            double a = 5.93576;
            int b = Convert.ToInt32(a);
            Console.WriteLine("1) " + b);
            int c = Convert.ToInt32(Math.Round(a));
            Console.WriteLine("2) " + c);
            int d = Convert.ToInt32(Math.Floor(a));
            Console.WriteLine("3) " + d);
            double e = Math.Round(a, 1);
            Console.WriteLine("4) " + e);
            int f = 5;
            int g = f++;
            Console.WriteLine("5) " + g);
            int h = 5;
            int i = ++h;
            Console.WriteLine("6) " + i);

            Console.WriteLine();
            Console.WriteLine("Задание №4: ");
            Console.WriteLine();
            Random rnd = new Random();
            int value = rnd.Next();
            Console.WriteLine(value);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выполнения описания
        /// </summary>
        /// <returns>Описания лабораторной</returns>
        public string Description()
        {
            return "Задания лабораторной №1";
        }

        /// <summary>
        /// Метод возвращает номер лабы
        /// </summary>
        /// <returns>Номер лабораторной</returns>
        public int Id()
        {
            return 1;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная работа №1.\nТема: Арифметические операции. Классы Random и Math. Приведение числовых типов данных. Округление. Суффиксы и префиксы.";
        }
    }
}
