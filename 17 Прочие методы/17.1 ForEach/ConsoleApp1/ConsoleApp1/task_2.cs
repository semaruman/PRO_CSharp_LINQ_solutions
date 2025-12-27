using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0;
        numbers.ForEach(x => sum += x);
        Console.WriteLine(sum);
    }
}