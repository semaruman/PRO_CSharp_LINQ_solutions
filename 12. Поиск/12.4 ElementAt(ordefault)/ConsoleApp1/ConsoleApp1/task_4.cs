using System;
using System.Linq;

public class MainClass4
{
    public static void Main()
    {
        // put your c# code here
        try
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 1).ElementAt(Convert.ToInt32(Console.ReadLine()) - 1));
        }
        catch
        {

        }
    }
}