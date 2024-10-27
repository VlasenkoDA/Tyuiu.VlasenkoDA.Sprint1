using Tyuiu.VlasenkoDA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                         *");
            Console.WriteLine("* Задание # 3                                                                     *");
            Console.WriteLine("* Вариант # 8                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                        *");
            Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются во время         *");
            Console.WriteLine("* работы программы. Ответ округлите до 3 знаков после запятой.                    *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");

            double startAmount;
            Console.Write("Введите начальную сумму по вкладу: ");
            startAmount = Convert.ToDouble(Console.ReadLine());

            double percent;
            Console.Write("Введите процентную ставку по вкладу: ");
            percent = Convert.ToDouble(Console.ReadLine());

            double timeDays;
            Console.Write("Введите количество дней по вкладу: ");
            timeDays = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double incomeAmount = ds.IncomeAmount(startAmount, percent, timeDays);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine($"* Доход по вкладу: {Math.Round(incomeAmount, 3)}                                 *");
            Console.WriteLine("***********************************************************************************");

            Console.ReadLine();
        }
    }
}
