using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabsInterface;

namespace LabsLib.Lab4
{
    internal class Lab4 : ILabs
    {
        /// <summary>
        /// Метод демоснтрации лабораторной
        /// </summary>
        public void Demo()
        {
            Console.WriteLine();
            Console.WriteLine("Задание №1: ");
            Console.WriteLine();
            int[] mass = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
                Console.Write(mass[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Задание №2: ");
            Console.WriteLine();
            string str = "awd 23 f 4 rg3 3";
            string[] strraz = str.Split(' ');
            foreach (string el in strraz)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            Console.WriteLine("Задание №3: ");
            Console.WriteLine();
            Console.Write("ВВедите размер массива n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива mas[{0}]=", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int tmp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Элемент массива mas[{0}]={1}", i, mas[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выполнения описания
        /// </summary>
        /// <returns>Описания лабораторной</returns>
        public string Description()
        {
            return "Задания лабораторной №4";
        }

        /// <summary>
        /// Метод возвращает номер лабы
        /// </summary>
        /// <returns>Номер лабораторной</returns>
        public int Id()
        {
            return 4;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная работа №4.\nТема: Массивы. Строки";
        }
    }
}
