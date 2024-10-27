using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoDA.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            // Перевод процентной ставки в долю
            double dailyRate = percent / 100 / 365;

            // Расчет дохода
            double income = startAmount * dailyRate * timeDays;

            // Округление до 3 знаков после запятой
            return Math.Round(income, 3);
        }
    }
}
