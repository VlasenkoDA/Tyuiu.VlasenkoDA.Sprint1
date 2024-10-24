using Tyuiu.VlasenkoDA.Sprint1.Task0.V8.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                     *");
            Console.WriteLine("* Задание # 0                                                                     *");
            Console.WriteLine("* Вариант # 8                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 15/2/4 и печатает результат     *");
            Console.WriteLine("* на экране.                                                                      *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Исходные данные: 15/2/4                                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("*Результат:                                                                       *");
            Console.WriteLine("***********************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();

        }
    }
}
