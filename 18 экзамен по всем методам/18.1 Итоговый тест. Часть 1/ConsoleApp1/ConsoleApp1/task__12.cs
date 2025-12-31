using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass12
{
    public static void Main12()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        var stack = new Stack<IEnumerable<char>>();

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            var digits = s.Where(x => char.IsDigit(x)).Reverse();
            stack.Push(digits);
        }

        var res = stack.SelectMany(str => string.Join("", str));

        Console.WriteLine(string.Join("", res));
    }
}
