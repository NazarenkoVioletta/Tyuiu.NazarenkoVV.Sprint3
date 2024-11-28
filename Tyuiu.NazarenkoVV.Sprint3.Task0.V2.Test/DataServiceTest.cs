using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using Tyuiu.NazarenkoVV.Sprint3.Task0.V2.Lib;
namespace Tyuiu.NazarenkoVV.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int start1 = 1;
            int finish2 = 9;
            var res = ds.GetMultiplySeries(start1, finish2);
            double wait = 0.021;
            Assert.AreEqual(wait, res);
        }
    }
}