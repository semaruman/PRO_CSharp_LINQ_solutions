using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string s = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(string.Join("", s.Take(n).Concat(s.TakeLast(m))));
    }
}