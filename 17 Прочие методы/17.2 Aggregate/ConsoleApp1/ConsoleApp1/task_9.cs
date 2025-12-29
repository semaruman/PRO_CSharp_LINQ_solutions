using System;
using System.Linq;

public class MainClass9
{
    public static void Main9()
    {
        // put your c# code here
        string[] words = Console.ReadLine().Split();
        Console.WriteLine(words.Aggregate("", (x, y) =>
        {
            x += y[0];
            return x;
        }, x => x.ToUpper()));
    }
}