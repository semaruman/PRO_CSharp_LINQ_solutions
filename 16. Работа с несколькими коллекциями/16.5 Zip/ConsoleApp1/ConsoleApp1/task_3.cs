using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class Program3
{
    public static void Main3()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] strings = Console.ReadLine().Split();

        if (strings.Length <  numbers.Length)
        {
            int raz = numbers.Length - strings.Length;
            List<string> strings1 = strings.ToList();

            for (int i = 0; i < raz; i++)
            {
                strings1.Add("");
            }
            Console.WriteLine(string.Join('\n', numbers.Zip(strings1).Select(tup => tup.Item1.ToString() + " " + tup.Item2)));
        }
        else
        {
            int raz = strings.Length - numbers.Length;
            List<string> strings1 = strings.TakeLast(raz).ToList();
            Console.WriteLine(string.Join('\n', numbers.Zip(strings).Select(tup => tup.Item1.ToString() + " " + tup.Item2)));
            Console.WriteLine(string.Join('\n', strings1));
        }

    }
}