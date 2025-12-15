using System;
using System.Linq;
using System.Collections.Generic;

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

    public override string ToString()
    {
        return $"{Name}, {Nickname}, {Age}";
    }
}

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        string[] strings = Console.ReadLine().Split("; ");
        List<User> users = new List<User>();
        foreach (string s in strings)
        {
            string[] temp = s.Split(", ");
            users.Add(new User(temp[0], temp[1], Convert.ToInt32(temp[2])));
        }
        string str = Console.ReadLine();

        Console.WriteLine(users.LastOrDefault(user => user.Nickname.Contains(str.ToLower())));
    }
}