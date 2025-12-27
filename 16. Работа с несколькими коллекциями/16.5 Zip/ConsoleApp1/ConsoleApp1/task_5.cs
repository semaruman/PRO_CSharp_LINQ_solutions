using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass5
{
    public static void Main()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string[] strings = Console.ReadLine().Split();

        Console.WriteLine(string.Join('\n', numbers.Zip(strings)));
    }
}
