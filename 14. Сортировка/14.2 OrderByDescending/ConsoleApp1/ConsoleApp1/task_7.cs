using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass7
{
    public static void Main()
    {
        // put your c# code here
        string s = "NoNull";
        Dictionary<string, int> dict = new Dictionary<string, int>();

        int dayCounter = 0;

        while (dayCounter <= 48)
        {
            s = Console.ReadLine();
            

            
            if (s == "" || s == null)
            {
                break;
            }
            else if (s == "Недавно решено задач:")
            {
                dayCounter++;
                continue;
            }

            string[] keyAndValue = s.Split(" ");

            if (dict.ContainsKey(keyAndValue[1]))
            {
                keyAndValue[0] = string.Join("", keyAndValue[0].Where(c => c != '+').ToArray());
                dict[keyAndValue[1]] += Convert.ToInt32(keyAndValue[0]);
            }
            else
            {
                keyAndValue[0] = string.Join("", keyAndValue[0].Where(c => c != '+').ToArray());
                dict[keyAndValue[1]] = Convert.ToInt32(keyAndValue[0]);
            }
        }

        List<string> keys = new List<string>();

        foreach (string key in dict.Keys)
        {
            keys.Add(key);
        }

        keys = keys.OrderByDescending(c => dict[c]).ToList();

        Console.WriteLine("Кол-во за день:");
        int number = 1;
        foreach (string key in keys)
        {
            Console.WriteLine($"{number++} {key} {dict[key]}");
        }
    }
}