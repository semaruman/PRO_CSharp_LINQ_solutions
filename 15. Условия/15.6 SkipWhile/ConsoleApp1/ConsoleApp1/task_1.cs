static class Ex
{
    public static IEnumerable<int> MySkipWhile(this IEnumerable<int> items, int value)
    {
        // реализовать логику

        bool flag = false;
        foreach (var item in items)
        {
            if (flag)
            {
                yield return item;
            }
            else if (item == value)
            {
                flag = true;
                yield return item;
            }
        }
    }
}

public class Program1
{
    public static void Main1()
    {
        var numbers = new List<int> { 8, 11, 19, 22, 25 };
        var controlNumber = 19;
        var result = numbers.MySkipWhile(controlNumber);
        Console.WriteLine(string.Join(' ', result));
    }
}