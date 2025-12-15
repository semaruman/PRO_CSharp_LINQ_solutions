using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        int res = 1;
        foreach (int number in numbers)
        {
            res *= number;
        }
        Console.WriteLine(res);
    }
}