static class Ex
{
    public static IEnumerable<int> MyTakeWhile(this IEnumerable<int> items, int value)
    {
        // реализовать логику
        foreach (int item in items)
        {
            if (item == value)
            {
                break;
            }
            yield return item;
        }
    }
}