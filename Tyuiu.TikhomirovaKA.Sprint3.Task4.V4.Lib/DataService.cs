using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task4.V4.Lib
{
    public class DataService : ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double y = 0;
            int i = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break;
                y += x/(Math.Cos(x) + Math.Sin(x));
                i++;
            }
            return Math.Round(y, 3);
        }
    }
}
