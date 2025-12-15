using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        char[] s = Console.ReadLine().Where(char.IsLetter).OrderBy(c => (int)c).ToArray();
        Console.WriteLine(string.Join("", s));
    }
}