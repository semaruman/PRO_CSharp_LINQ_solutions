using System;
using System.Linq;

public class MainClass4
{
    public static void Main()
    {
        // put your c# code here
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        numbers.RemoveAt(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x)));
    }
}