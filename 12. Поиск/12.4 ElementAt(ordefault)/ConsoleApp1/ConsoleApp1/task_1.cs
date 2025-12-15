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
    public static Student GetElementAt(IEnumerable<Student> students, int age, int index)
    {
        // реализовать логику
        int counter = 0;
        IEnumerable<Student> students1 = students.Where(st => st.Age > age);
        foreach (Student student in students1)
        {
            if (counter == index)
            {
                return student;
            }
            counter++;
        }
        throw new Exception("Студент не найден");
    }
}