static class Ex
{
    public static IEnumerable<int> MySkipLast(this IEnumerable<int> items, int count)
    {
        // реализовать логику
        int[] numbers = items.ToArray();
        for (int i = 0; i < numbers.Length - count; i++)
        {
            yield return numbers[i];
        }
    }
}
public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int> { 8, 11, 1, 1 };
        var passCountNumber = 3;
        var result = numbers.MySkipLast(passCountNumber);
        Console.WriteLine(string.Join(' ', result));
    }
}