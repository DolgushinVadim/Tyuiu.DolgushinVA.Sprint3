using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint3.Task4.V1.Lib;
namespace Tyuiu.DolgushinVA.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.962;
            Assert.AreEqual(wait, res);
        }
    }
}
