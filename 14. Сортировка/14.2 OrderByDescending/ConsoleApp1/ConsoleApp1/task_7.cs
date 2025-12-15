using System;
using System.Collections.Generic;

public class MainClass7
{
    public static void Main()
    {
        // put your c# code here
        string s = "NoNull";
        Dictionary<string, int> dict = new Dictionary<string, int>();

        int dayCounter = 0;

        while (s != "" && dayCounter <= 48)
        {
            s = Console.ReadLine();

            if (s == "Недавно решено задач:")
            {
                dayCounter++;
                continue;
            }

            string[] keyAndValue = s.Split(" ");

            if (dict.ContainsKey(keyAndValue[1]))
            {
                dict[keyAndValue[1]] += Convert.ToInt32(keyAndValue[0].Where(char.IsDigit));
            }
            else
            {
                dict[keyAndValue[1]] += Convert.ToInt32(keyAndValue[0].Where(char.IsDigit));
            }
        }
        
        Console.WriteLine();
    }
}