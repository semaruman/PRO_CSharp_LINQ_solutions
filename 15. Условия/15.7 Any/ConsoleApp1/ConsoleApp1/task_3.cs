using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        string s = Console.ReadLine();
        char c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(s.Any(ch => ch == c) ? "True" : "False");
    }
}