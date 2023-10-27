using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgushinVA.Sprint3.Task7.V14.Lib;
namespace Tyuiu.DolgushinVA.Sprint3.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Долгушин В. А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Долгушин Вадим Алексеевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x)= 2 * x - 4 + (2х - 1 / sin(x) + 1) (произвести табулирование) f(x) *");
            Console.WriteLine("* на заданном диапазоне [-5; 5] с шагом 1.Произвести проверку деления на  *");
            Console.WriteLine("* на ноль.При делении на ноль вернуть значение 0. Значения занести в      *");
            Console.WriteLine("* массив. Значения округлить до двух знаков после запятой.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueWaitArray = new double[len];
            valueWaitArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     x     |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1, 6:f2}   |", startValue, valueWaitArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");
            Console.Write("[" + valueWaitArray[0] + ", " + valueWaitArray[1] + ", " + valueWaitArray[2] + ", " + valueWaitArray[3] + ", " + valueWaitArray[4] + ", " + valueWaitArray[5] + ", " + valueWaitArray[6] + ", " + valueWaitArray[7] + ", " + valueWaitArray[8] + ", " + valueWaitArray[9] + ", " + valueWaitArray[10] + "]");
            Console.ReadKey();
        }
    }
}
