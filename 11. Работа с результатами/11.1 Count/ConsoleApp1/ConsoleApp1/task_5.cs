using System;
using System.Linq;

public class Program5
{
    public static void Main5()
    {
        string s = Console.ReadLine();

        Console.WriteLine(s[0] == '+' ? s.Count(c => c == '+') - s.Count(c => c == '-') : s.Count(c => c == '-') - s.Count(c => c == '+'));
    }
}