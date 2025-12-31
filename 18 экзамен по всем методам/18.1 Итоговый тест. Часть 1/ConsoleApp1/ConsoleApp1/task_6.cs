using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass6
{
    public static void Main6()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse);

        var res = numbers.Where(x => x % 2 == 0).Distinct();
        Console.WriteLine(string.Join(" ", res));
    }
}
