using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        List<string> strings = new List<string>();

        for (int i = 0; i < n; i++)
        {
            strings.Add(Console.ReadLine());
        }
        int count = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join('\n', strings.Select(str => string.Join("", str.Skip(count)))));
    }
}
