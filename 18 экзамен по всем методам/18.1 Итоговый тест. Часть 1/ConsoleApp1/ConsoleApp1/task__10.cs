using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass10
{
    public static void Main10()
    {
        // put your c# code here
    }
    public static IEnumerable<int> GetPositiveNumbers(IEnumerable<int> items)
    {
        // реализовать логику
        return items.Where(x => x > 0).Select(x => x % 10).Distinct();
    }
}
