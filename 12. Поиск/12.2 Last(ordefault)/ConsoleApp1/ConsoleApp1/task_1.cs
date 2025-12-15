static class Ex
{
    public static int MyLast(this IEnumerable<int> items)
    {
        // реализовать логику
        Stack<int> stack = new Stack<int>();
        foreach (int item in items)
        {
            stack.Push(item);
        }
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Последовательность не содержит элементов");
        }
        return stack.Peek();
    }
}