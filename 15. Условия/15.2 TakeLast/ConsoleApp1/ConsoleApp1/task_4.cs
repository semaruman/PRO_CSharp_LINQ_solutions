using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        List<string> songs = new List<string>();

        for (int _ = 0; _ < k; _++)
        {
            songs.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join("\n", songs.Distinct().TakeLast(n)));
    }
}