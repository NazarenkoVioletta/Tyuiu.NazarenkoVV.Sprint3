using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarenkoVV.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int min = 0, temp = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    temp++;
                    if (temp > min) min = temp;
                }
                else temp = 0;
            }
            return min;
        }
    }
}