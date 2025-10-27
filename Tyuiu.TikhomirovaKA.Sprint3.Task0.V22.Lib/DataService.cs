using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task0.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                result *= (Math.Pow(value, i) + 4) * Math.Cos(value);
            }
            return result;
        }
    }
}
