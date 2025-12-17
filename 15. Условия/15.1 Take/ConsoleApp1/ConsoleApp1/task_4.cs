using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        string s = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(s.Take(n).Where(char.IsDigit).Select(char.GetNumericValue).Sum());
    }
}