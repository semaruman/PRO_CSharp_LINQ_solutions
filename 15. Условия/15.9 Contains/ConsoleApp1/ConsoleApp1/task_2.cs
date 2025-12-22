using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        char[] sep = new char[] { ',', ' ', '.', '-', ';' };
        string word = Console.ReadLine().ToLower().Split(sep, StringSplitOptions.RemoveEmptyEntries).First();
        string[] s = Console.ReadLine().ToLower().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(s.Contains(word) ? "True" : "False");
    }
}