using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass8
{
    public static void Main8()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        List<string> strings = new List<string>();

        for (int i = 0; i < n; i++)
        {
            strings.Add(Console.ReadLine());
        }
        Console.WriteLine(strings.OrderBy(s => Convert.ToInt32(s.Split(", ")[1].Split(':')[0]) * 60 + Convert.ToInt32(s.Split(", ")[1].Split(':')[1])).Last().Split(", ")[0]);
    }
}