using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoDA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            return time / 3600;

        }
    }
}
