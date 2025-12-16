using System;
using System.Linq;

public class Program4
{
    public static void Main4()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool flag = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine(!flag ? string.Join(" ", numbers) : string.Join(" ", numbers.Reverse()));
    }
}