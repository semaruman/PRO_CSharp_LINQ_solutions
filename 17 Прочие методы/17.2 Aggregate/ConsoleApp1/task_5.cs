using System;
using System.Linq;

public class MainClass5
{
    public static void Main()
    {
        // put your c# code here
        string[] words = Console.ReadLine().Split();
        if (words.Count() > 1){
            Console.WriteLine(words.Aggregate((x, y) => x +=", " + y));
        }
        else
        {
            Console.WriteLine(words[0]);
        }
    }
}