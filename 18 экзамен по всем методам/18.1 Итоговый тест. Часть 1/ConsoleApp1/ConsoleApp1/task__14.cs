using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass14
{
    public static void Main14()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse);

        var keys = numbers.Select(n => n % 10).Distinct().OrderBy(x => x).ToList();

        keys.ForEach(key =>
        {
            Console.WriteLine($"{key}:{numbers.Where(n => n % 10 == key).Sum()}");
        });
    }
}
