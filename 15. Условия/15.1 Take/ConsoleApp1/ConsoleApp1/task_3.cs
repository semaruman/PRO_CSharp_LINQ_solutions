using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        string s = string.Join("", Console.ReadLine().Where(char.IsLetter)).ToLower();
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join("", s.OrderBy(c => c).Distinct().Take(n)));
    }
}