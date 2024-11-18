using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarenkoVV.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSerias = 1;
            while (startValue <= stopValue)
            {
                multSerias = multSerias * (Math.Pow(1 / Math.Pow(value, startValue), 3));
                startValue++;
            }
            return Math.Round(multSerias, 3);
        }
    }
}
        