using System;
using System.Collections.Generic;
using System.Linq;

public class Grade
{
    // Номер класса
    public int GradeNumber { get; set; }

    // Буква класса
    public char GradeLetter { get; set; }

    // Количество учеников в классе
    public int NumberOfStudents { get; set; }

    public Grade(int gradeNumber, char gradeLetter, int numberOfStudents)
    {
        GradeNumber = gradeNumber;
        GradeLetter = gradeLetter;
        NumberOfStudents = numberOfStudents;
    }
}

public class Program1
{
    public static void Main()
    {
        List<Grade> grades = new List<Grade>();
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine().Split();
            grades.Add(new Grade(Convert.ToInt32(s[0]), Convert.ToChar(s[1]), Convert.ToInt32(s[2])));
        }
        Console.WriteLine(string.Join(" ", grades.Where(grade => grade.NumberOfStudents < 30).DefaultIfEmpty(new Grade(50, 'Я', 1)).Select(grade => grade.GradeLetter)));
    }
}