using System;
using System.Globalization;
using System.Linq;

public class MainClass3
{
    public static void Main()
    {
        // put your c# code here
        int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.Write(string.Join(" ", numbers1.Except(numbers2))+ " ");

        Console.WriteLine(string.Join(" ", numbers3.Except(numbers2).Except(numbers1)));
    }
}