using System;
using System.Linq;

public class Program6
{
    public static void Main()
    {
        Console.ReadLine();
        Console.ReadLine();
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Console.WriteLine(-(numbers.Sum() - Convert.ToDouble(Console.ReadLine())*numbers.Count()));
    }
}