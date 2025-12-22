using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(numbers1.Concat(numbers2).Where(x => x % 2 == 0).Count());
    }
}