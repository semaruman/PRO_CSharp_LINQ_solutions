static class Ex
{
    public static bool MyAny(this IEnumerable<int> items)
    {
        // реализовать логику
        foreach (var item in items)
        {
            if (item %2 == 0)
            {
                return true;
            }
        }
        return false;
    }
}