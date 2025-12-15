public class Program2
{
    static void Main2()
    {
        var numbers = "1 2 3 4";
        var result = GetNumbers(numbers);
        Console.WriteLine(string.Join(' ', result));
    }
    static int[] GetNumbers(string input)
    {
        // реализовать логику
        string[] strings = input.Split(' ');
        return strings.Select(x => Convert.ToInt32(x)).ToArray();
    }
}