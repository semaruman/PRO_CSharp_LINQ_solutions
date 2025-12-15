using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().Split(", ").OrderBy(s => Convert.ToInt32(s.Split(':')[0]) * 60 + Convert.ToInt32(s.Split(':')[1])).ElementAt(0));
    }
}