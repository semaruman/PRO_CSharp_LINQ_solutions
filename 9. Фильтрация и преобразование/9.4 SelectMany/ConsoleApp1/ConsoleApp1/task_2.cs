public class Program2
{
    static void Main2()
    {
        var students = new List<Student>
    {
        new Student(26, "Mark", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq")
        }),
        new Student(22, "Alexey", new List<Lesson>
        {
            new Lesson("C++"),
            new Lesson("JavaScript")
        }),
        new Student(18, "Natasha", new List<Lesson>
        {
            new Lesson("SQL"),
            new Lesson("Python")
        }),

        new Student(20, "Elena", new List<Lesson>
        {
            new Lesson("C++"),
            new Lesson("PHP")
        }),

        new Student(26, "Joseph", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq"),
            new Lesson("Python"),
        })
    };
        var lessonNames = GetLessonNames(students);

        foreach (var item in lessonNames)
        {
            Console.WriteLine(item);
        }
    }
    static IEnumerable<string> GetLessonNames(IEnumerable<Student> students)
    {
        // реализовать логику
        return students.Where(x => x.Age > 20).SelectMany(x => x.Lessons).ToList().Select(x => x.Name);
    }
}