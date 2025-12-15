using System;
using System.Linq;
public class Student
{
    public string Name { get; }
    public int Age { get; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name}, {Age}";
    }
}

public class Program5
{
    static void Main5()
    {
        var students = new List<Student>
    {
        new Student("Anna", 23),
        new Student("Max", 22),
        new Student("Ivan", 24),
        new Student("Oleg", 25)
    };

        var result = students.OrderBy(st => st.Age);

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
    }
}