using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> ints = new List<int>();

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split(", ");
            ints.Add(Convert.ToInt32(temp[0]));
        }
        int sum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(ints.All(i => sum >= i) ? "True" : "False");
    }
}
