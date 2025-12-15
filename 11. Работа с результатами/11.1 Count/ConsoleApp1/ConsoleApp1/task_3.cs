public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public static class GetCountClass
{
    static int GetСount(IEnumerable<Student> students, int age)
    {
        // реализовать логику
        return students.Where(s => s.Age == age).Count();
    }
}