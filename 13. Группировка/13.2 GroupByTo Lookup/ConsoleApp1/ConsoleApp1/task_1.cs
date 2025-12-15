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
public class GroupStudents
{
    public int Age { get; set; }
    public IEnumerable<Student> Students { get; set; }

    public GroupStudents(int age, IEnumerable<Student> students)
    {
        Age = age;
        Students = students;
    }
}

public static class Ex
{
    public static IEnumerable<GroupStudents> GroupByAge(this IEnumerable<Student> students)
    {
        // реализовать логику

        List<GroupStudents> groups = new List<GroupStudents>();

        foreach (Student student in students)
        {
            bool groupInGroups = false;
            foreach (GroupStudents group in groups)
            {
                if (group.Age == student.Age)
                {
                    group.Students.Append(student);
                    groupInGroups = true;
                    break;
                }
            }
            if (!groupInGroups)
            {
                groups.Add(new GroupStudents(student.Age, new List<Student>()));
            }
        }
        return groups;
    }
}

public class Program1
{
    public static void Main1()
    {
        var students = new List<Student>
    {
        new Student("Svetlana", 21),
        new Student("Joseph", 22),
        new Student("Oleg", 23),
        new Student("Petr", 22),
        new Student("Anna", 24),
        new Student("Svetlana", 19),
        new Student("Ekatherina", 18),
        new Student("Ekatherina", 22)
    };
        var result = students.GroupByAge();
        foreach (var el in result)
        {
            Console.WriteLine(el.Age);

            foreach (var student in el.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}