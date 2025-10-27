using Tyuiu.TikhomirovaKA.Sprint3.Task6.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #3                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                  *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #20                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int startValue = 20;
        Console.WriteLine(startValue);
        int stopValue = 32;
        Console.WriteLine(stopValue);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();
    }
}