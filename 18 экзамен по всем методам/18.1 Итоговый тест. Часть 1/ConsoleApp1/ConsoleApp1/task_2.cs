using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string[] strings = Console.ReadLine().Split();
        char c = Convert.ToChar(Console.ReadLine());

        int correctCount = strings.Where(str => str.ToLower().Last() == char.ToLower(c)).Count();

        if (correctCount == 1)
        {
            Console.WriteLine(strings.First(str => str.ToLower().Last() == char.ToLower(c)));
        }
        else if (correctCount == 0) 
        {
            Console.WriteLine("Нет такого слова");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}