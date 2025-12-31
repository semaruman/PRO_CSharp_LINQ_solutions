using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        string[] strings = Console.ReadLine().Split();
        char c = Convert.ToChar(Console.ReadLine());

        int correctCount = strings.Where(str => str.ToLower().Where(chr => chr == char.ToLower(c)).Count() == 2).Count();

        Console.WriteLine(correctCount);
    }
}