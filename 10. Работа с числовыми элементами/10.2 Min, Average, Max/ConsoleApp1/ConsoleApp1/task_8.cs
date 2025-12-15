using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass8
{
    public static void Main()
    {
        // put your c# code here
        string[] s = Console.ReadLine().Split(", ");
        List<double> numbers = new List<double>();
        numbers.Add(Char.GetNumericValue(s[0][s[0].Length - 1]));
        for (int i = 1; i < s.Length; i++)
        {
            numbers.Add(Convert.ToInt32(s[i]));
        }
        Console.WriteLine(Math.Round(numbers.Average(), MidpointRounding.AwayFromZero));
    }
}