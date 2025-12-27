using System.Collections.Generic;
using System;
using System.Linq;

namespace LINQ
{
    public class Student
    {
        public string Name { get; }

        // Название профильного предмета
        public string MainSubjectName { get; }

        public Student(string name, string mainSubjectName)
        {
            Name = name;
            MainSubjectName = mainSubjectName;
        }
    }

    public class Subject
    {
        public string Name { get; }
        public string TeacherName { get; }

        public Subject(string name, string teacherName)
        {
            Name = name;
            TeacherName = teacherName;
        }
    }

    static class Program
    {
        static void Main()
        {
            var subjects = new List<Subject>
            {
                new Subject("Math", "Перельман П.П."),
                new Subject("History", "Суворов С.С."),
                new Subject("Programming", "Возняк В.В.")
            };

            var students = new List<Student>
            {
                new Student("Pavel", "Math"),
                new Student("Anna", "History"),
                new Student("Mark", "Programming"),
                new Student("Joseph", "Programming")
            };

            // вот здесь нужно писать код
            var studentsWithTeacherNames = students.Select(student =>
            {
                var mainSubject = subjects.SingleOrDefault(subject => subject.Name == student.MainSubjectName);
                return new
                {
                    Name = student.Name,
                    MainSubjectName = mainSubject.Name,
                    TeacherName = mainSubject.TeacherName,
                };
            });

            foreach (var item in studentsWithTeacherNames)
            {
                Console.WriteLine($"Студент: {item.Name}, " + $"Профильный предмет: {item.MainSubjectName}" + $"({item.TeacherName})");
            }
        }
    }
}