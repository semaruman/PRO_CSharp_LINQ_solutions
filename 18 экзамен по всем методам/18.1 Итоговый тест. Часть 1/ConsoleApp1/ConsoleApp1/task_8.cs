using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass8
{
    public static void Main8()
    {
        // put your c# code here
        string[] strings = Console.ReadLine().Split();

        var res = strings.OrderBy(x => x.Length).ThenByDescending(x => x);

        Console.WriteLine(string.Join(" ", res));
    }
}
