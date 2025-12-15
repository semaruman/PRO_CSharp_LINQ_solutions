public class Program1
{
    public static void Main1(string[] args)
    {
        string[] s = Console.ReadLine().Split(',');
        List<char> result = s.SelectMany((n, index) => $"{Convert.ToInt32(n)-1} {index}\n" + $"{Convert.ToInt32(n)} {index}\n" + $"{Convert.ToInt32(n) + 1} {index}\n").ToList();
        Console.WriteLine(string.Join("", result));
    }
}