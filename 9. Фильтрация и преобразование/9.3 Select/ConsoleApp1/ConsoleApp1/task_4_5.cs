using System.Linq;

class User
{
    public string Name { get; set; }

    public int Age { get; set; }
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
    static IEnumerable<User> GetUsers(string[] input)
    {
        // реализовать логику
        return input.Select(str => new User(str.Split(' ')[0], Convert.ToInt32(str.Split(' ')[1])));
    }
    static IEnumerable<string> GetAdulthoodNames(IEnumerable<User> users)
    {
        // реализовать логику
        return users.Where(u => u.Age >= 18).Select(u => u.Name);
    }
}