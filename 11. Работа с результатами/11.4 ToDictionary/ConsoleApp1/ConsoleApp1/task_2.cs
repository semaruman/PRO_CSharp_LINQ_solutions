using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        Dictionary<char, string> dict = Console.ReadLine().Split(' ').ToDictionary(str => str[0]);

        foreach (char c in dict.Keys)
        {
            Console.WriteLine($"{c} {dict[c]}");
        }
    }
}