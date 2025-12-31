using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass13
{
    public static void Main13()
    {
        // put your c# code here
        var A = Console.ReadLine().Split().Select(int.Parse);
        var B = Console.ReadLine().Split().Select(int.Parse);

        int[] k1k2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int k1 = k1k2[0];
        int k2 = k1k2[1];

        var a = A.Where(x => x > k1);
        var b = B.Where(x => x < k2);

        var res = a.Concat(b).OrderBy(x => x);

        Console.WriteLine(string.Join(" ", res));
    }
}