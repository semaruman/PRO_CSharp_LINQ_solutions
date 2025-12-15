using Microsoft.VisualBasic;

public class Program9
{
    public static void Main()
    {
        string https = Console.ReadLine();
        string home = Console.ReadLine();

        string s = $"{https}://{home}/";
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string path = Console.ReadLine();
            Console.WriteLine(s+path);
        }
    }
}