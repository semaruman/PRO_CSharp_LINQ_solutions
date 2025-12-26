static class Ex
{
    static IEnumerable<int> MyZip(this IEnumerable<int> items1, IEnumerable<int> items2)
    {
        // реализовать логику
        int newSize = Math.Min(items1.Count(), items2.Count());

        for (int i = 0; i < newSize; i++)
        {
            yield return items1.ElementAt(i) + items2.ElementAt(i);
        }
    }
}