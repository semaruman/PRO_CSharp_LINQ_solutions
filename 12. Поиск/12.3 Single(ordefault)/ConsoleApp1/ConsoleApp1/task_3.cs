using System;
using System.Linq;
using System.Collections.Generic;


public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        List<string> twoPerson = new List<string>();
        twoPerson.Add(Console.ReadLine());
        twoPerson.Add(Console.ReadLine());

        try
        {
            Console.WriteLine(twoPerson.Single(person => person.Split(", ")[1] == "true").Split(", ")[0]);
        }
        catch
        {
            Console.WriteLine("Нет");
        }
    }
}