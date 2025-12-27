using System;
using System.Linq;

public class Program4
{
    public static void Main4()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int c = 0;

        var res = s1.Zip(s2, (c1, c2) => c1.ToString() + c2.ToString());
        Console.WriteLine(string.Join(s1[0], res));
    }
}