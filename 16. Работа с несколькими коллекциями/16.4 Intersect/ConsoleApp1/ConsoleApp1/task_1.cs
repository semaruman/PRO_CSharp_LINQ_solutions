static class Ex
{
    public static IEnumerable<int> MyIntersect(this IEnumerable<int> items1, IEnumerable<int> items2)
    {
        // реализовать логику
        List<int> result = new List<int>();

        foreach (int item in items1)
        {
            if (items2.Contains(item))
            {
                result.Add(item);
            }
        }

        return result.Distinct();
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbersFirst = new List<int> { 1, 2, 3, 4, 5, 5 };
        var numbersSecond = new List<int> { 5, 6, 7, 8, 9 };
        var result = numbersFirst.MyIntersect(numbersSecond);
        Console.WriteLine(string.Join(' ', result));
    }
}