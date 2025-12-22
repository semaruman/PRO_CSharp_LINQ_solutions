using System;
using System.Linq;

public class Program3
{
    public static void Main3()
    {
        char[] sep = new char[] {',', ' ', '.', '-', ';' };
        string[] words = Console.ReadLine().ToLower().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int n = Convert.ToInt32(Console.ReadLine());
        char c = char.ToLower(Convert.ToChar(Console.ReadLine()));
        Console.WriteLine(words.OrderByDescending(word => word.Length).Take(n).All(word => word.Any(ch => ch == c)) ? "True" : "False");
        //Console.WriteLine(string.Join("\n", words.OrderByDescending(word => word.Length).Take(n)));
    }
}