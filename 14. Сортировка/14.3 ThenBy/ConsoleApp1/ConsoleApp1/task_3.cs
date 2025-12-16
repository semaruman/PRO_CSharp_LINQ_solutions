public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }
}
public class ClassRoom
{
    public List<Student> Students { get; set; }

    public ClassRoom(List<Student> students)
    {
        Students = students;
    }
}

public class Program3
{
    static void Main3(string[] args)
    {
        var classroom1 = new ClassRoom(new List<Student>());
        var classroom2 = new ClassRoom(new List<Student>());
        ClassRoom[] classrooms = { classroom1, classroom2 };
        var orderedStudents = classrooms.SelectMany(cr => cr.Students.Where(st => st.Age > 20)).OrderBy(st => st.Name).ThenBy(st => st.Age);
    }
}