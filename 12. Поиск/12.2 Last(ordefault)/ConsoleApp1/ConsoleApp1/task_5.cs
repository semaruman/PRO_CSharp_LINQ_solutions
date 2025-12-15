using System;
using System.Linq;

public class MainClass5
{
    public static void Main5()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().Split(", ").Select(int.Parse).LastOrDefault(x => x % 2 != 0));
    }
}