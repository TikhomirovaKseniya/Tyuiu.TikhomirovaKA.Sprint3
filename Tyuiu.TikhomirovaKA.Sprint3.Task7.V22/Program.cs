using Tyuiu.TikhomirovaKA.Sprint3.Task7.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #3                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                  *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #22                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int startValue = -5;
        Console.WriteLine(startValue);
        int stopValue = 5;
        Console.WriteLine(stopValue);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        double[] values = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine(string.Join(", ", values));
        Console.ReadKey();
    }
}