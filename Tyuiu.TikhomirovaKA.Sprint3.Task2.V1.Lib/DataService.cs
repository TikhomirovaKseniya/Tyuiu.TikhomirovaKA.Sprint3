using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double result = 0;
            do
            {
                result += Math.Sin(startValue) * Math.Pow(0.5, 2);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(result, 3);
        }
    }
}
