using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {                  
            foreach (char n in value)
            {
                if (Char.IsDigit(n))
                {
                    value = value.Replace(n, item);
                }
            }
            return value;
        }
    }
}
