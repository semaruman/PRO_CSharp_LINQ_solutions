using System;
using System.Linq;

public class MainClass6
{
    public static void Main6()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().Split(' ').Select(x => x.Sum(c => Char.GetNumericValue(c))).Max());
    }
}