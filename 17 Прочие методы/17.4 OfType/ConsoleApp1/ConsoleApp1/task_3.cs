using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace LearnLinq
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            List<object> wrongList = new List<object>
            {
                new Person("Иван", 30),
                new Person("Петр", 25),
                42,
                "Павел"
            };

            // ваш код начинается здесь

            var persons = wrongList.OfType<Person>().ToList();

            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}