using System.Linq;

public static class EnumerableExtensions
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> items, Func<T, bool> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var numbersBiggerThanFive = numbers.MyWhere(x => x > 5);
        Console.WriteLine(string.Join(" ", numbersBiggerThanFive));
    }
}