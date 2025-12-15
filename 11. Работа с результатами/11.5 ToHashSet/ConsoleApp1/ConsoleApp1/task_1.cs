static class Ex
{
    static HashSet<T> MyToHashSet<T>(this IEnumerable<T> items)
    {
        // реализовать логику
        HashSet<T> set = new HashSet<T>();
        foreach (T item in items)
        {
            set.Add(item);
        }
        return set;
    }
}