public class Program
{
    static void Main(string[] args)
    {
        var number = 1;

        var divisionNumbers = Division(number);

        foreach (var divisionNumber in divisionNumbers)
        {
            Console.WriteLine(divisionNumber);
        }
    }
    public static IEnumerable<int> Division(int n)
    {
        if (n != 0)
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i / n;
            }
        }
        else
        {
            Console.WriteLine("Поймали: Attempted to divide by zero.");
            yield break;
        }
    }
}