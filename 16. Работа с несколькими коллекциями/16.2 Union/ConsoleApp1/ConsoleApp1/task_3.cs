using System;
using System.Linq;

public class MainClass3
{
    public static void Main()
    {
        // put your c# code here
        int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(numbers1.Union(numbers2).Average());
    }
}