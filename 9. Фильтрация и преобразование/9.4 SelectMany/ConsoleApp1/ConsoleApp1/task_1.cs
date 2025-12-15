
public class Lesson
{
    public string Name { get; set; }
    public Lesson(string name)
    {
        Name = name;
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Lesson> Lessons { get; set; }

    public Student(int age, string name, List<Lesson> lessons)
    {
        Age = age;
        Name = name;
        Lessons = lessons;
    }
}

public class Program1
{
    static void Main1()
    {
        var students = new List<Student> {

        new Student(26, "Mark", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq")
        }),

        new Student(26, "Joseph", new List<Lesson>
        {
            new Lesson("Основы программирования"),
            new Lesson("C# для продвинутых"),
            new Lesson("Linq"),
            new Lesson("ASP.Net Core")
        })
        };


        var allLessons = GetLessons(students);

        foreach (var item in allLessons)
        {
            Console.WriteLine(item.Name);
        }
    }

    static IEnumerable<Lesson> GetLessons(IEnumerable<Student> students)
    {
        // реализовать логику
        List<Lesson> lessons = new List<Lesson>();
        foreach (var student in students)
        {
            lessons.AddRange(student.Lessons);
        }
        return lessons;
    }
}