using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass9
{
    public static void Main9()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse);

        int[] k1k2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int k1 = k1k2[0];
        int k2 = k1k2[1];

        int res = numbers.Skip(k1 - 1).Take(k2 - k1 + 1).Sum();

        Console.WriteLine(res);
    }
}
