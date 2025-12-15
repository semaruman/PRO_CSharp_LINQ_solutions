using System.Globalization;

static class Ex
{
    public static IEnumerable<int> MyOrderByDescending(this IEnumerable<int> items)
    {
        // реализовать логику
        int[] numbers = items.ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            int maxIndex = i;

            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] > numbers[maxIndex])
                {
                    maxIndex = j;
                }
            }

            int tempNumber = numbers[i];
            numbers[i] = numbers[maxIndex];
            numbers[maxIndex] = tempNumber;
        }

        return numbers;
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int>
    {
        5, 2, 1, 4, 3
    };
        var result = numbers.MyOrderByDescending();
        Console.WriteLine(string.Join(' ', result));
    }
}