using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass5
{
    public static void Main5()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse);

        Console.WriteLine(numbers.Where(n => n>=10 && n<100).Min());
        Console.WriteLine(numbers.Where(n => n<=-10 && n>-100).Max());
        Console.WriteLine(numbers.Where(n => (n >= 10 && n < 100 || n <= -10 && n > -100)).Average());
    }
}
