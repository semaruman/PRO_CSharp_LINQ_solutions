using System;
using System.Linq;


public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        string s = string.Join("", Console.ReadLine().Where(char.IsLetterOrDigit)).ToLower();
        Console.WriteLine(s == string.Join("", s.Reverse()) ? "True":"False");
    }
}