static class Ex
{
    static int MyFirst(this IEnumerable<int> items)
    {
        // реализовать логику
        foreach (var item in items)
        {
            return item;
        }
        throw new InvalidOperationException("Последовательность не содержит элементов");
    }
}