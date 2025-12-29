using System;
using System.Linq;

public class MainClass8
{
    public static void Main8()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] diap = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int res = numbers.Aggregate(0, (x, y) =>
        {
            if (y >= diap[0] && y<= diap[1])
            {
                x += 1;
            }
            return x;
        }, x => x);

        Console.WriteLine(res);
    }
}