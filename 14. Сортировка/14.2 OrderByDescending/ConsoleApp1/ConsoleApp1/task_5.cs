using System;
using System.Linq;

public class MainClass5
{
    public static void Main5()
    {
        // put your c# code here
        string number = Console.ReadLine();

        int resCounter = 0;

        while (number != "6174")
        {
            resCounter++;

            string bigNumber = string.Join("", number.OrderByDescending(x => char.GetNumericValue(x)));
            string smallNumber = string.Join("", number.OrderBy(x => char.GetNumericValue(x)));

            number = (Convert.ToInt32(bigNumber) - Convert.ToInt32(smallNumber)).ToString();
        }
        Console.WriteLine(resCounter);
    }
}