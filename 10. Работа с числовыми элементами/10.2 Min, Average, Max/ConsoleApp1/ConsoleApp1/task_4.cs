using System;
using System.Linq;

public class Program4
{
    public static void Main4()
    {
        Console.WriteLine(Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).Where(x => x % 2 == 1 || x % 2 == -1).Min());
    }
}