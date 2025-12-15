using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x%2==0).Sum());
    }
}