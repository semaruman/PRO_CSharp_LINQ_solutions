using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        string s3 = Console.ReadLine();

        var c1 = s1.Cast<char>();
        var c2 = s2.Cast<char>();
        var c3 = s3.Cast<char>();

        Console.WriteLine(string.Join(" ", c1) + " " + string.Join(" ", c2) + " " + string.Join(" ", c3));
    }
}