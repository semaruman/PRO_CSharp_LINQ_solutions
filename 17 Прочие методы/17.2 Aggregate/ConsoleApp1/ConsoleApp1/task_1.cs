static class Ex
{
    public static int MyAggregate(this IEnumerable<int> items)
    {
        // реализовать логику

        int res = 1;

        foreach (var item in items)
        {
            res *= item;
        }
        return res;
    }
}