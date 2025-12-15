public class User
{
    public string Name { get; }
    public int Age { get; }
    public int FriendsCount { get; }

    public User(string name, int age, int friendsCount)
    {
        Name = name;
        Age = age;
        FriendsCount = friendsCount;
    }
}

public class Program4
{
    public static void Main4()
    {
        var users = new List<User>
    {
        new User ("Иосиф", 27, 850),
        new User ("Марк", 26, 1025),
        new User ("Маша", 20, 12313)
    };
        var result = SortByFriendsCount(users);
        foreach (var user in result)
            Console.WriteLine(user.Name);
    }
    static IEnumerable<User> SortByFriendsCount(IEnumerable<User> users)
    {
        // реализовать логику
        return users.OrderByDescending(x => x.FriendsCount);
    }
}