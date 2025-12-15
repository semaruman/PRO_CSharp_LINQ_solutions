using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass3
{
    public static void Main()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        Dictionary<int, string> dict = numbers.ToDictionary(number => number, number => number % 2 == 1?"True":"False");
        foreach (int number in dict.Keys)
        {
            Console.WriteLine($"{number} {dict[number]}");
        }
    }
}