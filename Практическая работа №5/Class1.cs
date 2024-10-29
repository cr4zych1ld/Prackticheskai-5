using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__5
{
    /// <summary>
    /// Класс для сравнения пар чисел
    /// </summary>
    public class Pair
    {
        /// <summary>
        /// Автоматическое свойство для первого числа в паре чисел
        /// </summary>
        public double First { get; set; }
        /// <summary>
        /// Автоматическое свойство для второго числа в паре чисел
        /// </summary>
        public double Second { get; set; }

        /// <summary>
        /// Параметризованный конструктор для класса Pair
        /// </summary>
        /// <param name="first">Первое число</param>
        /// <param name="second">Второе число</param>
        public Pair(double first, double second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// Метод для установки параметров объекта
        /// </summary>
        /// <param name="first">Первое число</param>
        /// <param name="second">Второе число</param>
        public void SetParams(double first, double second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// Перегруженный метод для установки параметров объекта
        /// </summary>
        /// <param name="pair">Переменная обозначающая пару чисел</param>
        public void SetParams(Pair pair)
        {
            First = pair.First;
            Second = pair.Second;
        }

        /// <summary>
        /// Метод для сравнения пар чисел
        /// </summary>
        /// <param name="other">Переменная обозначающая другую пару чисел</param>
        /// <returns>Вывод результата сравнения пар</returns>
        public bool Sravnenie(Pair other)
        {
            if (First > other.First)
            {
                return true;
            }
            else if (First == other.First && Second > other.Second)
            {
                return true;
            }
            else return false;
        }
    }
}
