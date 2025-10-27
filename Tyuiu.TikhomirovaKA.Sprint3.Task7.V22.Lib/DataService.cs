using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task7.V22.Lib
{
    public class DataService : ISprint3Task7V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = (stopValue - startValue) + 1;
            double[] results = new double[length];
            for (int i = startValue; i <= stopValue; i++)
            {
                double fx = Math.Sin(i) + ((Math.Cos(2 * i))/ 2) - 1.5 * i;
                if (fx == 0) break; else results[i - startValue] = Math.Round(fx, 2);
            }   
            return results;
        }
    }
}
