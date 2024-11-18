using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarenkoVV.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries = multSeries * (1 / Math.Pow(Math.Cos(5) + 1, 2));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);

        }
    }
}
