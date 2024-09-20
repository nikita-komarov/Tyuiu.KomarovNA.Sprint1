﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KomarovNA.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task2V7
    {

        public double CalculateSquareCircle(int value)
        {
            return (double)Math.Round(Math.PI * Math.Pow(value, 2), 3);
        }
    }
}
