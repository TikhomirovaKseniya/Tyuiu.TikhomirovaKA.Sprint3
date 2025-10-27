using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                result *= (Math.Pow(value, i) - (1/4)) * Math.Cos(5);
            }
            return Math.Round(result, 3);
        }
    }
}
