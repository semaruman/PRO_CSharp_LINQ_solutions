using System;
using System.Collections.Generic;
using System.Linq;
public class MainClass2
{
    public static void Main()
    {
        // put your c# code here
        HashSet<string> set = Console.ReadLine().Split(", ").ToHashSet();
        
        Console.WriteLine(string.Join(", ", set));
    }
}