using Tyuiu.NazarenkoVV.Sprint3.Task6.V2.Lib;

namespace Tyuiu.NazarenkoVV.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void GetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 29;
            Assert.AreEqual(res, wait);
        }
    }
}