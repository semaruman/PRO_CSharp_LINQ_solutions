using System;
using System.Linq;

public class MainClass2
{
    public static void Main()
    {
        // put your c# code here
        string del = Console.ReadLine();
        string s = Console.ReadLine();

        Console.WriteLine(string.Join(" ", s.Split(del.Where(c => !char.IsDigit(c)).ToArray(), StringSplitOptions.RemoveEmptyEntries)));
    }
}