﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MyshakinD.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return x * Math.Pow((x + 1) / (Math.Pow(Math.Sin(x), 2) + x - 0.5), x);
            }
            else if (x == 0)
            {
                return (Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 4) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12);
            }
            else if (x > -31 & x < 0)
            {
                return (Math.Pow(1 + (1/Math.Pow(x, 2)), 2));
            }
            else
            {
                return x + Math.Pow(Math.Sin(x), 5) + Math.Pow(x, 3) - (2/x);
            }
        }
    }
}
