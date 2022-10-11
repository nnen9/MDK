using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs
{
    internal class Lab3 : ILabs
    {
        /// <summary>
        /// Метод демоснтрации лабораторной
        /// </summary>
        public void Demo()
        {
            Console.WriteLine();
            Console.WriteLine("Задание №1.1: ");
            Console.WriteLine();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание №1.2: ");
            Console.WriteLine();
            int j = 0;
            while (j <= 100)
            {
                if (j % 15 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            Console.WriteLine();
            Console.WriteLine("Задание №1.3");
            Console.WriteLine();
            int z = 0;
            do
            {
                if (z % 15 == 0)
                {
                    Console.WriteLine(z);
                }
                z++;
            }
            while (z <= 100);

            Console.WriteLine();
            Console.WriteLine("Задание №2");
            Console.WriteLine();
            int x = 0;
            int sum = 0;
            int musor = 0;
            for (x = 0; x <= 30; x++)
            {
                if (x % 2 == 0)
                {
                    musor += x;
                }
                else
                {
                    sum += x;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выполнения описания
        /// </summary>
        /// <returns>Описания лабораторной</returns>
        public string Description()
        {
            return "Задания лабораторной №3";
        }

        /// <summary>
        /// Метод возвращает номер лабы
        /// </summary>
        /// <returns>Номер лабораторной</returns>
        public int Id()
        {
            return 3;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная работа №3.\nТема: Циклы.";
        }
    }
}
