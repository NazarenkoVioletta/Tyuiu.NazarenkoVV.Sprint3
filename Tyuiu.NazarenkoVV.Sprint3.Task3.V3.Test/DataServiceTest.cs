using Newtonsoft.Json.Linq;
using Tyuiu.NazarenkoVV.Sprint3.Task3.V3.Lib;

namespace Tyuiu.NazarenkoVV.Sprint3.Task.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMinCharCount()
        {
            DataService ds = new DataService();
            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            double res = ds.GetMinCharCount(value, item);
            int wait = 6;
            Assert.AreEqual(res, wait);
        }
    }
}