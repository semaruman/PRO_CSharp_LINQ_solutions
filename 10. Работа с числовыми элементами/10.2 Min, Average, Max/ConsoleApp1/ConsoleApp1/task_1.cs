public static class MinClass
{
    static int MyMin(this IEnumerable<int> items)
    {
        int min = 100000000;
        foreach(int item in items)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }
}