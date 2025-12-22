static class Ex
{
    public static bool MyContains(this IEnumerable<int> items, int value)
    {
        // реализовать логику
        foreach (var item in items)
        {
            if (item == value) return true;
        }
        return false;
    }
}