using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass11
{
    public static void Main11()
    {
        // put your c# code here
        string[] strings = Console.ReadLine().Split();

        var res = strings.Select(str =>
        {
            if (str.Length % 2 != 0)
            {
                return str.First();
            }
            else
            {
                return str.Last();
            }
        }).OrderByDescending(str => str);

        Console.WriteLine(string.Join(" ", res));
    }
}
