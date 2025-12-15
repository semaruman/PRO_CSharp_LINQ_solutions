using System;
using System.Linq;

public class MainClass9
{
    public static void Main9()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().Where(char.IsLetter).Select(char.ToLower).Distinct().OrderBy(c => (int)c).Last());
    }
}