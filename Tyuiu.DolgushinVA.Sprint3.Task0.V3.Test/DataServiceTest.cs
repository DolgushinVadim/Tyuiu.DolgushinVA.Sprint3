using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint3.Task0.V3.Lib;
namespace Tyuiu.DolgushinVA.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 0.353;
            Assert.AreEqual(wait, res);

        }
    }
}
