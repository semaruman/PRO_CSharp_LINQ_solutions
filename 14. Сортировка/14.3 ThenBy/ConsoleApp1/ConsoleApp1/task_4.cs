using System;
using System.Linq;

public class City
{
    public string Name { get; }
    public int CitizensCount { get; }

    public City(string name, int citizensCount)
    {
        Name = name;
        CitizensCount = citizensCount;
    }

    public override string ToString()
    {
        return $"{Name}, {CitizensCount}";
    }
}

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split(", ");
            dict[temp[0]] = Convert.ToInt32(temp[1]);
        }

        //dict = dict.OrderBy(x => x.Key).ThenBy(x => x.Value).ToDictionary();

        string[] keys = dict.Keys.OrderBy(x => dict[x]).ThenBy(x => x).ToArray();

        foreach (string key in keys)
        {
            Console.WriteLine($"{key}, {dict[key]}");
        }
    }
}
