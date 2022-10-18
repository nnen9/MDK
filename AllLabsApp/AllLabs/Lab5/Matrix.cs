using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs.Lab5
{
    internal class Matrix11
    {
        public void Matrix1()
        {
            Random rnd = new Random();
            int[,] mass = new int[5, 5];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(0, 100);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Главная диагональ");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i, i] + "\t");
            }
            Console.WriteLine("Побочная диагональ");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[mass.GetLength(1) - i - 1, i] + "\t");
            }
            Console.WriteLine("Сумма всех элементов");
            int summa = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    summa += mass[i, j];
                }
            }
            Console.WriteLine(summa);
        }
    }
}
