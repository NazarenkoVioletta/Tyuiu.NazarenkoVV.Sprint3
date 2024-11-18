using Tyuiu.NazarenkoVV.Sprint3.Task2.V8.Lib;

namespace Tyuiu.NazarenkoVV.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int stopvalue = 15;
            double res = ds.GetMultiplySeries( startvalue, stopvalue);
            double wait = 0.277;
            Assert.AreEqual(res, wait);
        }
    }
}