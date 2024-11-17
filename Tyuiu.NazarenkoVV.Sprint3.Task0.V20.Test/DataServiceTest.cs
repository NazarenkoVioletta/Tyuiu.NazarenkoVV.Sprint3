using Tyuiu.NazarenkoVV.Sprint3.Task0.V20.Lib;

namespace Tyuiu.NazarenkoVV.Sprint3.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 14;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 63.353;
            Assert.AreEqual(wait, res);
        }      
    }
}

