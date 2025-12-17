using System;
using System.Linq;

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        Console.WriteLine(Console.ReadLine().TakeLast(3).Select(char.GetNumericValue).Sum());
    }
}