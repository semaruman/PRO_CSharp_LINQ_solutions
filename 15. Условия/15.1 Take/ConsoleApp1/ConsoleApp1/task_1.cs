static class Ex
{
    public static IEnumerable<int> MyTake(this IEnumerable<int> items, int count)
    {
        // реализовать логику
        int counter = 0;
        foreach (int item in items)
        {
            if (counter == count)
            {
                break;
            }

            yield return item;
            counter++;
        }
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int> { 8, 11 };
        var countNumbers = 3;
        var result = numbers.MyTake(countNumbers);
        Console.WriteLine(string.Join(' ', result));
    }
}