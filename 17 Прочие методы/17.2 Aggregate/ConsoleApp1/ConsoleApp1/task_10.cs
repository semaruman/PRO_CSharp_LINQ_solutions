using System;
using System.Linq;

public class Program10
{
    public static void Main10()
    {
        var numbers = new List<List<int>>
   {
        new List<int> {1, 2},
        new List<int> {3, 4},
        new List<int> {5, 6}
    };
        var result = Mult(numbers);
        Console.WriteLine(result);
    }
    public static int Mult(List<List<int>> items)
    {
        // реализовать логику
        return items.SelectMany(_ => _).Aggregate((x, y) => x * y);
    }
}