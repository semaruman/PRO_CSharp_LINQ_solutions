using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string[] s = string.Join("",Console.ReadLine().Where(c => c != ',').Select(c => char.ToLower(c))).Split(" ");
        s = s.OrderByDescending(str => str.Length).ThenBy(str => str).ToArray();
        Console.WriteLine(string.Join("\n", s));
    }
}