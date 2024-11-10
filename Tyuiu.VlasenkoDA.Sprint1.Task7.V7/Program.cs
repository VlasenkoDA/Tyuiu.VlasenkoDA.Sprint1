using System;
using Tyuiu.VlasenkoDA.Sprint1.Task7.V7.Lib;  // Добавление пространства имен для DataService

namespace Tyuiu.VlasenkoDA.Sprint1.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                         *");
            Console.WriteLine("* Задание # 7                                                                     *");
            Console.WriteLine("* Вариант # 7                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                  *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                           *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");
            DataService dataService = new DataService();
            double x, y;
            Console.WriteLine("Введите значение для x:");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число для x.");
            }
            Console.WriteLine("Введите значение для y:");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число для y.");
            }
            double result = dataService.Calculate(x, y);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine(result);
            Console.WriteLine("***********************************************************************************");
            Console.ReadLine();
        }
    }
}
