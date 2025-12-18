using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = Convert.ToInt32(Console.ReadLine());
        numbers = numbers.SkipWhile(number => number % 10 != n).ToArray();
        Console.Write(numbers[0]+" ");

        Console.WriteLine(string.Join(" ", numbers.Skip(1).TakeWhile(number => number%(n*2)!=0)));
    }
}