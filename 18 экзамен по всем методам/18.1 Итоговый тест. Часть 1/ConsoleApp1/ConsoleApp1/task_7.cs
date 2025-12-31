using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass7
{
    public static void Main7()
    {
        // put your c# code here
        var numbers = Console.ReadLine().Split().Select(int.Parse);

        var res = numbers.Where(x => x%2!=0).Reverse();

        Console.WriteLine(string.Join(" ", res));
    }
}
