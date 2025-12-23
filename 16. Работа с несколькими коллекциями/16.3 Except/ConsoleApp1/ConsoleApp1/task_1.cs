static class Ex
{
    static IEnumerable<int> MyExcept(this IEnumerable<int> items1, IEnumerable<int> items2)
    {
        // реализовать логику
        HashSet<int> items2set = new HashSet<int>(items2);

        foreach (var item in items1)
        {
            if (items2set.Add(item))
            {
                yield return item;
            }
        }
    }
}