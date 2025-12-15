using System;
using System.Linq;

public class MainClass7
{
    public static void Main7()
    {
        // put your c# code here
        char[] s = Console.ReadLine().Where(char.IsLetter).Select(c => char.ToLower(c)).Distinct().OrderBy(c => (int)c).ToArray();
        Console.WriteLine(string.Join(", ", s));
    }
}