static class Ex
{
    static bool MyAll(this IEnumerable<int> items)
    {
        // реализовать логику
        foreach (var item in items)
        {
            if (item %2 != 0)
            {
                return false;
            }
        }
        return true;
    }
}