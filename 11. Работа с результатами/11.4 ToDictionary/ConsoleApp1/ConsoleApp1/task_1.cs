public class Employee
{
    public int Id { get; }
    public string Name { get; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

static class Ex
{
    static Dictionary<int, Employee> MyToDictionary(this IEnumerable<Employee> employees)
    {
        // реализовать логику
        Dictionary<int, Employee> dect = new Dictionary<int, Employee>();

        foreach (Employee employee in employees)
        {
            if (dect.ContainsKey(employee.Id))
            {
                throw new Exception($"Ключ {employee.Id} уже существует.");
            }
            dect[employee.Id] = employee;
        }
        return dect;
    }
}