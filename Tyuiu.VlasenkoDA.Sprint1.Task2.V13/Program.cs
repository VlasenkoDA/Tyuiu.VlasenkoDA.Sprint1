using Tyuiu.VlasenkoDA.Sprint1.Task2.V13.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                             *");
            Console.WriteLine("* Задание # 2                                                                     *");
            Console.WriteLine("* Вариант # 13                                                                    *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                     *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Известно расстояние в милях. Вычислить расстояние в километрах.                 *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                      *");
            Console.WriteLine("***********************************************************************************");

            int x;
            Console.Write("Введите значение x (в милях): ");
            x = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            double resultInKm = ds.ConvertMilesToKm(x);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine($"* Расстояние в километрах: {Math.Round(resultInKm, 3)}                           *");
            Console.WriteLine("***********************************************************************************");

            Console.ReadLine();
        }
    }
}
