using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        string[] numbers = Console.ReadLine().Split(", ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join(", ", numbers.SkipLast(n).OrderBy(str => str)));
    }
}