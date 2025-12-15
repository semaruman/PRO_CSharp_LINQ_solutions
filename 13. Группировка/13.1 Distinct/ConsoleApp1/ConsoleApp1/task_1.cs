using System.Globalization;

static class Ex
{
    public static IEnumerable<int> MyDistinct(this IEnumerable<int> items)
    {
        // реализовать логику
        List<int> numbers = new List<int>();
        foreach (int item in items)
        {
            if (!numbers.Contains(item))
            {
                numbers.Add(item);
            }
        }
        return numbers;
    }
}