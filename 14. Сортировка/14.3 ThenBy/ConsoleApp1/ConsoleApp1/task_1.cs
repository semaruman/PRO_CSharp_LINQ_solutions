public class User
{
    public string Name { get; }
    public string Nickname { get; }
    public int Age { get; }

    public User(string name, string nickname, int age)
    {
        Name = name;
        Nickname = nickname;
        Age = age;
    }
}

static class Ex
{
    public static IEnumerable<User> MyOrderByThenBy(this IEnumerable<User> users)
    {
        // реализовать логику
        User[] userArray = users.ToArray();

        userArray = userArray.OrderBy(x => x.Name).ToArray();

        for (int i = 0; i < userArray.Length; i++)
        {
            int minIndex = i;

            for (int j = i;j < userArray.Length; j++)
            {
                if (userArray[minIndex].Name == userArray[j].Name && userArray[minIndex].Age > userArray[j].Age)
                {
                    minIndex = j;
                }
            }

            User temp = userArray[i];
            userArray[i] = userArray[minIndex];
            userArray[minIndex] = temp;
        }

        return userArray;
    }


}