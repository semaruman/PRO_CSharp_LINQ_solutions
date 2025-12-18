using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = Convert.ToInt32(Console.ReadLine());

        int summator = 0;
        foreach (int i in numbers)
        {
            summator += i;
            if (summator > n)
            {
                break;
            }
        }

        Console.WriteLine(summator);
    }
}
