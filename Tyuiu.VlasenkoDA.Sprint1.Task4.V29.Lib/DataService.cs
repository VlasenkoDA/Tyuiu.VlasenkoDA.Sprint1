using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoDA.Sprint1.Task4.V29.Lib
{
    public class DataService : ISprint1Task4V29
    {
        public double Calculate(double x, double y)
        {
            return Math.Sqrt(2.0 + Math.Abs(x - 2 * y)) / (3 * x * Math.Pow(y, 2));
        }
    }
}
