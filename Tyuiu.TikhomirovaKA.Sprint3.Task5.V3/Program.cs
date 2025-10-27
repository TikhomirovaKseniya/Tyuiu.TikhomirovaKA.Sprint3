using Tyuiu.TikhomirovaKA.Sprint3.Task5.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #3                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                  *");
        Console.WriteLine("* Задание #5                                                             *");
        Console.WriteLine("* Вариант #3                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int x = 5;
        Console.WriteLine("x = " + x);
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 11;

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        Console.ReadKey();
    }
}