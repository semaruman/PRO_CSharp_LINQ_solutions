using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string del = "!, .1234567890";
        Console.WriteLine(Console.ReadLine().Where(c => !del.Contains(c)).Count());
    }
}