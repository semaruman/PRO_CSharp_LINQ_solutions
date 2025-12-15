public class Program8
{
    static void Main8()
    {
        var years = new List<int> { 2020, 2022, 2023, 2024, 2400 };

        var result = GetLeapYear(years);

        Console.WriteLine(string.Join("\n", result));
    }
    static IEnumerable<string> GetLeapYear(List<int> years)
    {
        return years.Where(x => (x % 4 == 0 && x % 100 != 0) || x % 400 == 0).Select(x => $"{x} год високосный");
    }
}