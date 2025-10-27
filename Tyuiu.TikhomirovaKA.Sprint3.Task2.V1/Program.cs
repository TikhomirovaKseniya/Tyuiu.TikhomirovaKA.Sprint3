using Tyuiu.TikhomirovaKA.Sprint3.Task2.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #3                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                  *");
        Console.WriteLine("* Задание #2                                                             *");
        Console.WriteLine("* Вариант #1                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int startValue;
        startValue = Convert.ToInt32(Console.ReadLine());
        int stopValue;
        stopValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.GetSumSeries(startValue, stopValue));
        Console.ReadKey();
    }
}