﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs
{
    public interface ILabs
    {
        /// <summary>
        /// Метод демонстрации отработки всех заданий лабораторной работы
        /// </summary>
        void Demo();

        /// <summary>
        /// Заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        string Name();

        /// <summary>
        /// Описание заданий
        /// </summary>
        /// <returns></returns>
        string Description();

        /// <summary>
        /// Идентификатор (номер) лабораторной работы
        /// </summary>
        /// <returns></returns>
        int Id();
    }
}
