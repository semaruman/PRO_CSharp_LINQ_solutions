using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here

        int resCounter = 0;

        for (int i = 10000; i < 100000; i++)
        {
            if (IsPalindrom(i))
            {
                resCounter++;
            }
        }
        Console.WriteLine(resCounter);

    }
    static bool IsPalindrom(int number)
    {
        string n = number.ToString();
        return n == string.Join("", n.Reverse().ToArray());
    }
}