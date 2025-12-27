using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        numbers.ForEach(n => Console.Write(n*2 + " "));
    }
}