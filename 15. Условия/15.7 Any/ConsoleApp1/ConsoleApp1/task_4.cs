using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        string s = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());

        List<string> list = new List<string>();

        for (int i = 0; i < n; i++)
        {
            list.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join("\n", list.Where(str => str.Any(c => s.Any(ch => ch == c)))));
    }
}