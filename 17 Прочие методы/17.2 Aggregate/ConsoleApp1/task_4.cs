using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        string[] words = Console.ReadLine().Split();
        string res = words.Aggregate((x, y) => x.Length > y.Length? x : y);
        Console.WriteLine(res);
    }
}