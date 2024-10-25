using Tyuiu.VlasenkoDA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                         *");
            Console.WriteLine("* Задание # 1                                                                     *");
            Console.WriteLine("* Вариант # 24                                                                    *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
            Console.WriteLine("* вычисляет результат по формуле (1-x)/(2+y) и печатает его на экране.            *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Исходные данные:  (1-x)/(2+y)                                                   *");
            Console.WriteLine("***********************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("*Результат:                                                                       *");
            Console.WriteLine("***********************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();

        }
    }
}
