using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            while (startValue <= stopValue)
            {
                result *= (Math.Pow(value, startValue) - 0.25) * Math.Cos(5);
                startValue++;
            }
            return Math.Round(result, 3);
        }
    }
}
