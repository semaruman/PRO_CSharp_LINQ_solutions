using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse).Distinct();
        Console.WriteLine(numbers.OrderBy(x => x).ToArray()[numbers.Count() - 2]);
    }
}