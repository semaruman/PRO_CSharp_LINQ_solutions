using System;
using System.Collections.Generic;
using System.Linq;


public class Student : IEquatable<Student>
{
    public string Name { get; }
    public int Age { get; }


    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Age}, {Name}";
    }

    public bool Equals(Student other)
    {
        return this.Age == other.Age && this.Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}

public class Program2
{
    public static void Main2(string[] args)
    {
        List<Student> students1 = new List<Student>();
        List<Student> students2 = new List<Student>();

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(", ");
            students1.Add(new Student(Convert.ToInt32(s[0]), s[1]));
        }

        int m = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] s = Console.ReadLine().Split(", ");
            students2.Add(new Student(Convert.ToInt32(s[0]), s[1]));
        }

        Console.WriteLine(string.Join('\n', students1.Union(students2)));
    }
}