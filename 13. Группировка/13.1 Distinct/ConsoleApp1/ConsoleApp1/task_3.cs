using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        Console.WriteLine(numbers.Where(x => x%2==0).Sum() - numbers.Where(x => x%2!=0).Sum());
    }
}