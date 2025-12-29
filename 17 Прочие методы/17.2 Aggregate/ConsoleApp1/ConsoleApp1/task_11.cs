using System;
using System.Linq;
using System.Collections.Generic;


public class Program11
{
    static void Main()
    {
        // Здесь ваш код
        int n = Convert.ToInt32(Console.ReadLine());
        List<Person> list = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split();
            list.Add(new Person(temp[0], Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2])));
        }

        Console.WriteLine(list.Where(p => p.Age > 25).Average(p => p.Salary));
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}