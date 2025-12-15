public class Program2
{
    static void Main2()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int n = 25;

        var result = Method(numbers, n);

        Console.WriteLine(string.Join(" ", result));
    }

    static IEnumerable<int> Method(IEnumerable<int> numbers, int n)
    {
        return numbers.Where(number => number * number > n);
    }
}