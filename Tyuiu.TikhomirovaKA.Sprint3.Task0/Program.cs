using Tyuiu.TikhomirovaKA.Sprint3.Task0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #3                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                  *");
        Console.WriteLine("* Задание #0                                                             *");
        Console.WriteLine("* Вариант #22                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        double value = 0.25;
        Console.WriteLine(value);
        int startValue = 1;
        Console.WriteLine(startValue);
        int stopValue = 8;
        Console.WriteLine(stopValue);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}