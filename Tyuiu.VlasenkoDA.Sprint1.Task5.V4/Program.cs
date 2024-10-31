using System;
using Tyuiu.VlasenkoDA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task5.V4.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                      *");
            Console.WriteLine("* Задание # 5                                                                     *");
            Console.WriteLine("* Вариант # 4                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                            *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)                    *");
            Console.WriteLine("* прошло к этому моменту (например, h=3, если k=13257)                            *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Введите количество секунд с начала суток:");
            int k = int.Parse(Console.ReadLine());
            int hours = ds.SecondsToHours(k);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine($"*Прошло полных часов: {hours}                                                    *");
            Console.WriteLine("***********************************************************************************");
            Console.ReadLine();
        }
    }
}
