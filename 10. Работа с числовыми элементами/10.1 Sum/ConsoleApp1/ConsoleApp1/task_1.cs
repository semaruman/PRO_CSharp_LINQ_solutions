using System.Linq;

public static class SUM
{
    public static int MySum(this IEnumerable<int> numbers)
    {
        int s = 0;
        foreach (int number in numbers)
        {
            s += number;
        }
        return s;
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        var result = numbers.MySum();
        Console.WriteLine(result);
    }
}