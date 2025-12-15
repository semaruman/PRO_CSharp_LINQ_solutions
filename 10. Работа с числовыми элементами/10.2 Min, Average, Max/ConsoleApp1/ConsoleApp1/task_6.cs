public class User
{
    public string Name { get; set; }
    public string Nickname { get; set; }
    public int Age { get; set; }

    public User(string name, string nickname, int age)
    {
        Name = name;
        Nickname = nickname;
        Age = age;
    }
}

public class Program6
{
    public static void Main6()
    {
        var users = new List<User>
    {
        new User ("Анна", "Scorpion", 22),
        new User ("Николай", "TheDestroyer817", 28),
        new User ("Сергей", "RainingMan", 35),
        new User ("Андрей", "Mr.A", 19)
    };

        var result = GetShortestNicknameLength(users);
        Console.WriteLine(result);
    }

    static int GetShortestNicknameLength(IEnumerable<User> users)
    {
        // реализовать логику
        return users.Min(u => u.Nickname.Length);
    }
}