static class Ex
{
    public static IEnumerable<int> MyDefaultIfEmpty(this IEnumerable<int> items, int defaultValue)
    {
        foreach (var _ in items)
        {
            return items;
        }
        return items.Append(defaultValue);
    }
}