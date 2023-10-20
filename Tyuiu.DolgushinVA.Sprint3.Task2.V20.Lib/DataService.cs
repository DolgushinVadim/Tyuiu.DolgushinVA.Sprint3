using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolgushinVA.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries = multSeries * (Math.Pow((2.0 / (Math.Cos(value) + 0.5)), startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
