public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int age, string name)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Age}, {Name}";
    }
}

static class Ex
{
    public static Student GetSingle(IEnumerable<Student> students, int age)
    {
        // реализовать логику
        int counter = 0;
        Student resStudent = null;

        foreach (Student student in students)
        {
            if (student.Age == age)
            {
                counter++;
                resStudent = student;
            }
            if (counter > 1)
            {
                throw new Exception("Неверное количество студентов");
            }
        }
        if (counter == 0)
        {
            throw new Exception("Неверное количество студентов");
        }
        return resStudent;
    }
}