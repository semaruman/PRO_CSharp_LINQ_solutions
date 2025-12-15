using System;
using System.Linq;
public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        try
        {
            Console.WriteLine(Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).First());
        }
        catch
        {
            Console.WriteLine("Подходящего числа нет");
        }
    }
}