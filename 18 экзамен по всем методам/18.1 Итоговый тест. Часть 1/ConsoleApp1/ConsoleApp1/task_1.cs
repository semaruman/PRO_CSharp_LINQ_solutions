using System;
using System.Linq;

public class MainClass1
{
    public static void Main1()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse);
        int el1 = numbers.First(n => n > 0);
        int el2 = numbers.Last(n => n < 0);
        Console.WriteLine(el1 + " " + el2);
    }
}