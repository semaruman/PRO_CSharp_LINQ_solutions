using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string[] surnames = Console.ReadLine().Split();
        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= surnames.Length)
        {
            Console.WriteLine(surnames[0]);
            return;
        }
        Console.WriteLine(string.Join(" ", surnames.SkipLast(n)));
    }
}