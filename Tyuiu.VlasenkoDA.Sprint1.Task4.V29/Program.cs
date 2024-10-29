using System;
using Tyuiu.VlasenkoDA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Class Math                                                                *");
            Console.WriteLine("* Задание # 4                                                                     *");
            Console.WriteLine("* Вариант # 29                                                                    *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                        *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");
            // Запрашиваем у пользователя значения x и y
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Вычисляем значение по формуле
            double result = Math.Sqrt(2.0 + Math.Abs(x - 2 * y)) / (3 * x * Math.Pow(y, 2));
            result = Math.Round(result, 3);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine($"* {result}                                                                       *");
            Console.WriteLine("***********************************************************************************");
            Console.ReadLine();
            
        }
    }
}
