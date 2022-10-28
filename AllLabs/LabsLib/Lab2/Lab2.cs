using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabsInterface;

namespace LabsLib.Lab2
{
    internal class Lab2 : ILabs
    {
        /// <summary>
        /// Метод демоснтрации лабораторной
        /// </summary>  
        public void Demo()
        {
            Console.WriteLine();
            Console.WriteLine("Задание №1: ");
            Console.WriteLine();
            Console.Write("Введите число: ");
            int number = 0;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out number);
                if (res == true)
                {
                    if ((number >= 1) && (number <= 7))

                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                        }
                        if (number == 1)
                        {
                            Console.WriteLine("Понедельник");
                        }
                        if (number == 2)
                        {
                            Console.WriteLine("Вторник");
                        }
                        if (number == 3)
                        {
                            Console.WriteLine("Среда");
                        }
                        if (number == 4)
                        {
                            Console.WriteLine("Четверг");
                        }
                        if (number == 5)
                        {
                            Console.WriteLine("Пятница");
                        }
                        if (number == 6)
                        {
                            Console.WriteLine("Суббота");
                        }
                        if (number == 7)
                        {
                            Console.WriteLine("Воскресенье");
                        }
                    }
                    else Console.WriteLine("Ошибка");

                }
                else Console.WriteLine("Ошибка");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Задание №2: ");
            Console.WriteLine();
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("BuzzFizz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

            Console.WriteLine();
            Console.WriteLine("Задание №3: ");
            Console.WriteLine();
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак: ");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine(a + b);
            }
            if (c == "-")
            {
                Console.WriteLine(a - b);
            }
            if (c == "*")
            {
                Console.WriteLine(a * b);
            }
            if (c == "/")
            {
                Console.WriteLine(a / b);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выполнения описания
        /// </summary>
        /// <returns>Описания лабораторной</returns>
        public string Description()
        {
            return "Задания лабораторной №2";
        }

        /// <summary>
        /// Метод возвращает номер лабы
        /// </summary>
        /// <returns>Номер лабораторной</returns>
        public int Id()
        {
            return 2;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная работа №2.\nТема: Условия. Операторы сравнения";
        }
    }
}
