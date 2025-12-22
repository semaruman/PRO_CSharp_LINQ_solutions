static class Ex
{
    public static IEnumerable<int> MyConcat(this IEnumerable<int> items1, IEnumerable<int> items2)
    {
        // реализовать логику
        List<int> result = new List<int>(items1);
        result.AddRange(items2);
        return result;
    }
}