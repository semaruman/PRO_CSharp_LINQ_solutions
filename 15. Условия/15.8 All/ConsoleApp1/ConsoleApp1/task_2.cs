using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(numbers.Skip(n).All(number => GetDigitsSum(number) > k)?"True":"False");
    }
    static int GetDigitsSum(int number)
    {
        string s = number.ToString();
        int resSum = 0;
        foreach (char c in s)
        {
            resSum += Convert.ToInt32(char.GetNumericValue(c));
        }
        return resSum;
    }
}