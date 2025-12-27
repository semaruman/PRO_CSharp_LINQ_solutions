using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        List<string> strings = Console.ReadLine().Split().ToList();
        char c = Convert.ToChar(Console.ReadLine());

        strings.ForEach(s => { if (s[0] == c) Console.WriteLine(s); });
    }
}