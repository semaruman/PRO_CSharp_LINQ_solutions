static class Ex
{
    public static IEnumerable<int> MyUnion(this IEnumerable<int> items1, IEnumerable<int> items2)
    {
        // реализовать логику
        List<int> result = new List<int>(items1.Distinct());
        foreach (int item in items2.Distinct())
        {
            if (!result.Contains(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
}