static class Ex2
{
    static string MyAggregateString(this IEnumerable<string> items)
    {
        // реализовать логику
        string res = "";
        foreach (var item in items)
        {
            res += item;
        }
        return res;
    }
}