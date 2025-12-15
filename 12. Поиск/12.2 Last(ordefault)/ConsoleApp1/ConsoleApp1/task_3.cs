public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Age}, {Name}";
    }
}

public class Program3
{
    public static void Main3()
    {
        var students = new List<Student>
    {
        new Student ( "Svetlana", 21 ),
        new Student ( "Joseph", 22 ),
        new Student ( "Oleg", 23 ),
        new Student ( "Petr", 22 ),
        new Student ( "Anna", 24 ),
        new Student ( "Svetlana", 19 ),
        new Student ( "Ekatherina", 18 ),
        new Student ( "Ekatherina", 22 )
    };
        var ageForFind = 22;
        var result = GetLast(students, ageForFind);
        Console.WriteLine(result);
    }
    static Student GetLast(IEnumerable<Student> students, int age)
    {
        // реализовать логику
        try
        {
            return students.Where(s => s.Age > age).Last();
        }
        catch
        {
            throw new Exception("Студент не найден");
        }
    }
}