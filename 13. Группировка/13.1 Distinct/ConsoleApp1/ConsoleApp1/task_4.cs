using System;
using System.Linq;

public class MainClass4
{
    public static void Main()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().Where(c => char.IsLetterOrDigit(c)).Select(c => (int)c).Distinct().Sum());
    }
}