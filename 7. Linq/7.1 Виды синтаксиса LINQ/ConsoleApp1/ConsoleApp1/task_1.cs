public class Program1
{
    static void Main1()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = GetNumbersBiggerThanFive(numbers);
        Console.WriteLine(string.Join(' ', result));
    }
    static List<int> GetNumbersBiggerThanFive(List<int> numbers)
    {
        List<int> result = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 5)
            {
                result.Add(number);
            }
        }
        return result;
    }
}