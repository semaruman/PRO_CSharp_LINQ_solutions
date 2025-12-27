using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(string.Join(" ", numbers1.TakeWhile(num => num != n).Intersect(numbers2)));
    }
}