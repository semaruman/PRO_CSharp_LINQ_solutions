using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass5
{
    public static void Main()
    {
        // put your c# code here
        string song = Console.ReadLine().ToLower();
        int n = Convert.ToInt32(Console.ReadLine());

        List<string> truePhoneNumbers = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string[] answer = Console.ReadLine().Split(": ");
            if (answer[1].ToLower() == song)
            {
                truePhoneNumbers.Add(answer[0]);
            }
        }
        Console.WriteLine(string.Join(", ", truePhoneNumbers.TakeLast(3)));
    }
}