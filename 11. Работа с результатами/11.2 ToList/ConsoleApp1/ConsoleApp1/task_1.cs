public static class MyToListClass
{
    public static List<T> MyToList<T>(this IEnumerable<T> items)
    {
        return new List<T>(items);
    }
}