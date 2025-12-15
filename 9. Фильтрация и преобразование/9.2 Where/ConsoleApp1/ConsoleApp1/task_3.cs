public class Program3
{
    static void Main3()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int n = 25;

        var result = Method(numbers, n);

        Console.WriteLine(string.Join(" ", result));
    }

    private static int Square(int x)
    {
        return x * x;
    }

    private static bool IsBigger(int x, int y)
    {
        return x > y;
    }
    static IEnumerable<int> Method(IEnumerable<int> numbers, int n)
    {
        // реализовать логику
        return numbers.Where(number => IsBigger(Square(number), n));
    }
}