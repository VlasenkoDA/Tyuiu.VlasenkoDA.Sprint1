using System;
using Tyuiu.VlasenkoDA.Sprint1.Task6.V4.Lib; // Путь к вашей библиотеке, если она находится в другом проекте

namespace Tyuiu.VlasenkoDA.Sprint1.Task6.V4.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                      *");
            Console.WriteLine("* Задание # 6                                                                     *");
            Console.WriteLine("* Вариант # 4                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,            *");
            Console.WriteLine("* содержащие удвоенное н (\"нн\").                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");
            var dataService = new DataService();
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();
            string result = dataService.CheckDoubleN(inputText);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Слова с удвоенной буквой 'н':");
            Console.WriteLine(result);
            Console.WriteLine("***********************************************************************************");
            Console.ReadLine();
           
        }
    }
}
