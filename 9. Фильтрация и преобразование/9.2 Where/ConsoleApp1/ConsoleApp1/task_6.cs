public class Program6
{
    static void Main6()
    {
        string input = Console.ReadLine();
        var numbers = new List<int>();

        foreach (var number in input.Split())
        {
            numbers.Add(Convert.ToInt32(number));
        }

        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
    }
}