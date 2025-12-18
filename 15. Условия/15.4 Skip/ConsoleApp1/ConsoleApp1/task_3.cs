using System;
using System.Collections.Generic;
using System.Linq;

public class Program3
{
    public static void Main3(string[] args)
    {
        int count = Convert.ToInt32(Console.ReadLine());
        List<string> students = new List<string>();

        for (int i = 0; i < count; i++)
        {
            students.Add(Console.ReadLine());
        }
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        students = students.OrderBy(st => st).ToList();
        Console.WriteLine(string.Join('\n', students.Skip(n*(k - 1)).Take(n)));
    }
}