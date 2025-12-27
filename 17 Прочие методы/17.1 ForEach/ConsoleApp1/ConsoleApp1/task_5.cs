using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass5
{
    public static void Main5()
    {
        // put your c# code here
        List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

        numbers2.ForEach(n => Console.Write(n + " "));
        numbers1.ForEach(n => Console.Write(n + " "));
    }
}