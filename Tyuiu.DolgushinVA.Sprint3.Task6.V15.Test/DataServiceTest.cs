using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint3.Task6.V15.Lib;
namespace Tyuiu.DolgushinVA.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 6;
            int stopValue = 15;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 168;
            Assert.AreEqual(wait, res);
        }
    }
}
