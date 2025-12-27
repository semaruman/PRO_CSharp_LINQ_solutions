using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEssentials
{
    class Program
    {
        class Subject
        {
            public string Title { get; set; }
            public int Grade { get; set; }

            public Subject(string title, int grade)
            {
                Title = title;
                Grade = grade;
            }
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<Subject> Subjects { get; set; }

            public Student(string firstName, string lastName, List<Subject> subjects)
            {
                FirstName = firstName;
                LastName = lastName;
                Subjects = subjects;
            }
        }

        static void Main8()
        {
            // ваш код здесь
            int n = Convert.ToInt32(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> temp = Console.ReadLine().Split(',').ToList();
                string firstName = temp[0];
                string lastName = temp[1];

                List<Subject> subjects = new List<Subject>();

                temp = temp.Skip(2).ToList();
                
                for (int j = 0; j < temp.Count; j+=2)
                {
                    subjects.Add(new Subject(temp[j], Convert.ToInt32(temp[j+1])));
                }

                students.Add(new Student(firstName, lastName, subjects));
            }

            students.ForEach(st =>
            {
                double s = 0;
                st.Subjects.ForEach(subject =>
                {
                    s += subject.Grade;
                });
                Console.WriteLine($"{st.FirstName} {st.LastName}-{Math.Round(s/st.Subjects.Count, 2)}");
            });
        }
    }
}