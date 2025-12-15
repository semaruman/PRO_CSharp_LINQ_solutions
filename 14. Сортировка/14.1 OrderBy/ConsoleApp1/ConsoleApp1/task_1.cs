static class Ex
{
    public static IEnumerable<int> MyOrderBy(this IEnumerable<int> items)
    {
        // реализовать логику

        int[] numbers = items.ToArray();

        for (int i = 0; i < items.Count(); i++)
        {
            int minIndex = i;
            for (int j = i; j < items.Count(); j++)
            {
                if (numbers[minIndex] > numbers[j])
                {
                    minIndex = j;
                }
            }
            int tempNumber = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = tempNumber;
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
        var result = numbers.MyOrderBy();
        Console.WriteLine(string.Join(' ', result));
    }
}