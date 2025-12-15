using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string s = Console.ReadLine();
        if (s.Count() % 2 == 0)
        {
            Console.WriteLine(s.ElementAt(s.Count() / 2 - 1));
        }
        else
        {
            Console.WriteLine(s.ElementAt(s.Count() / 2));
        }
    }
}