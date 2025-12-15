using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        List<string> people = new List<string>();


        for (int i = 0; i < n; i++)
        {
            people.Add(Console.ReadLine());
        }
        try
        {
            Console.WriteLine(people.Where(person => person.Split(", ")[1] == "false" && person.Split(", ")[2] == "true").Single().Split(", ")[0]);
        }
        catch
        {
            Console.WriteLine("Тупик");
        }
    }
}