using System;
using System.Linq;

public class MainClass7
{
    public static void Main7()
    {
        // put your c# code here
        double[] words = Console.ReadLine().Split().Select(word => char.GetNumericValue(word.Last())).ToArray();
        Console.WriteLine(words.Aggregate((cur, next) => cur + next) / (double)words.Length);
    }
}