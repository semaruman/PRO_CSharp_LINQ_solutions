static class Ex
{
    public static T[] MyToArray<T>(this IEnumerable<T> items)
    {
        T[] array = new T[items.Count()];
        int i = 0;
        foreach(T item in items)
        {
            array[i] = item;
            i++;
        }
        return array;
    }
}