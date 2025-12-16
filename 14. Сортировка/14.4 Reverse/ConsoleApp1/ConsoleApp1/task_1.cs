static class Ex
{
    public static IEnumerable<int> MyReverse(this IEnumerable<int> items)
    {
        // реализовать логику
        Stack<int> stack = new Stack<int>();
        foreach (int item in items)
        {
            stack.Push(item);
        }
        return stack.ToArray();
    }
}