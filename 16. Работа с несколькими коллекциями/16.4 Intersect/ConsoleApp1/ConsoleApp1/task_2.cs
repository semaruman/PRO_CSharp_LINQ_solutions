using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        char[] letters1 = Console.ReadLine().ToLower().Where(char.IsLetter).ToArray();
        char[] letters2 = Console.ReadLine().ToLower().Where(char.IsLetter).ToArray();
        char[] res = letters1.Intersect(letters2).ToArray();
        res = res.OrderBy(c => c).ToArray();
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join("", res.TakeLast(n)));
    }
}