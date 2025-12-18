using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Age}, {Name}";
    }
}

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split(", ");
            students.Add(new Student(Convert.ToInt32(temp[0]), temp[1]));
        }
        char C = Convert.ToChar(Console.ReadLine());

        Console.WriteLine(string.Join("\n", students.OrderBy(st => st.Name).TakeWhile(student => char.ToLower(student.Name[0]) <= C)));
    }
}