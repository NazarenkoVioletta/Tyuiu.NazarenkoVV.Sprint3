﻿using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarenkoVV.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multySeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multySeries = multySeries + (Math.Cos(value) + (Math.Pow((i / 8), 3)));
            }
            return Math.Round(multySeries, 3);

        }
    }
}