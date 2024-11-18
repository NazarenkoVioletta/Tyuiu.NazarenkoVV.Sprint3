using Tyuiu.NazarenkoVV.Sprint3.Task1.V27.Lib;

namespace Tyuiu.NazarenkoVV.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startvalue = 1;
            int stopvalue = 5;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);
            double wait = 55.365;
            Assert.AreEqual(res, wait);
        }
    }
}