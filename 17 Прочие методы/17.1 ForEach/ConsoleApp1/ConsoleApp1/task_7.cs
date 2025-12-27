using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program7
{

    public static void Main7()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        List<Person> list = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split();
            list.Add(new Person { Name = temp[0], Age = Convert.ToInt32(temp[1]) });
        }
        list = list.OrderBy(x => x.Name[0]).ThenBy(x => x.Age).ToList();

        list.ForEach(x => Console.WriteLine($"{x.Name} {x.Age}"));
    }
}