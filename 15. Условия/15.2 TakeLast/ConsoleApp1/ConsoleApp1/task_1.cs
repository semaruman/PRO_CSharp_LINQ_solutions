static class Ex
{
    public static IEnumerable<int> MyTakeLast(this IEnumerable<int> items, int count)
    {
        // реализовать логику
        int[] numbers = items.ToArray();
        for (int i = numbers.Length - count; i < numbers.Length; i++)
        {
            try
            {
                int _ = numbers[i];
            }
            catch (IndexOutOfRangeException)
            {
                continue;
            }
            yield return numbers[i];
        }
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int> { 8, 11, 13, 2, 5, 3 };
        var countNumbers = 2;
        var result = numbers.MyTakeLast(countNumbers);
        Console.WriteLine(string.Join(' ', result));
    }
}