using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass6
{
    public static void Main6()
    {
        // put your c# code here
        List<string> words = Console.ReadLine().Split().ToList();

        words.ForEach(word => Console.WriteLine(string.Join("",word.Reverse())));
    }
}