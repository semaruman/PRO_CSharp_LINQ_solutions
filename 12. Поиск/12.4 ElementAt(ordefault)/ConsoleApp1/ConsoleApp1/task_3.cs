using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        string s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine($"{s.ElementAt(i)} {s.ElementAt(s.Length - i - 1)}");
        }
    }
}