using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolgushinVA.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * ((Math.Cos(value)) + ((Convert.ToDouble(startValue)) / 4.0));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
