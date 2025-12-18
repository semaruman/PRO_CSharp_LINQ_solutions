static class Ex
{
    public static IEnumerable<int> MySkip(this IEnumerable<int> items, int count)
    {
        // реализовать логику
        int c = 0;
        foreach (int item in items)
        {
            if (c++ >= count)
            {
                yield return item;
            }
        }
    }
}