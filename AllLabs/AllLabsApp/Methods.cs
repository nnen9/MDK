using LabsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsApp
{
    public class Methods
    {
        /// <summary>
        /// Метод запускает Demo по введенному ID
        /// </summary>
        /// <param name="labs"></param>
        /// <param name="id"></param>
        public static void Demo(List<ILabs> labs, string id)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                foreach (ILabs lab in labs)
                {
                    if (ID == lab.Id())
                    {
                        lab.Demo();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Неверная команда. Попробуйте еще раз.");
            }
        }

        /// <summary>
        /// Метод выводит информацию обо всех доступных лабораторных
        /// </summary>
        /// <param name="labs"></param>
        public static void LabsInfo(List<ILabs> labs)
        {
            foreach (ILabs lab in labs)
            {
                Console.WriteLine(lab.Name());
                Console.WriteLine(lab.Description());
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод очищает экран
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Метод выводит все доступные команды
        /// </summary>
        public static void Help()
        {
            string[] commands =
            {
            "<ID> - запуск демонстрации лабораторной по номеру",
            "<exit> - выход",
            "<help> - список доступных команд",
            "<clear> - очистка экрана",
            "<info> - вывод информации о всех лабораторных"
        };

            foreach (string command in commands)
            {
                Console.WriteLine(command);
            }
        }
    }
}
