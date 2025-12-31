using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        string[] strings = Console.ReadLine().Split();

        int res = strings.Sum(s => s.Length);

        Console.WriteLine(res);
    }
}
