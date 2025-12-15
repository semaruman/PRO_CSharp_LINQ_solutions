static class CountClass
{
    static int MyCount(this IEnumerable<int> items)
    {
        int count = 0;
        foreach(var _ in items)
        {
            count++;
        }
        return count;
    }
}