using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoDA.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {
            // Вычисление первой части формулы
            double part1 = Math.Cos(x);

            // Вычисление второй части формулы
            double part2 = Math.PI - 2 * Math.Pow(y, x);

            // Вычисление третьей части формулы
            double part3 = 16 * x * Math.Cos(x * y);

            // Итоговый результат
            double z = part1 / part2 + part3 - 2;

            return Math.Round(z, 3);


        }
    }
}
