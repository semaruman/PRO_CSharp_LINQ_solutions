using System.Linq;

static class Ex
{
    public static IEnumerable<T> MyOfType<T>(this IEnumerable<object> items)
    {
        foreach (object item in items)
        {
            if (item is T)
            {
                yield return (T)item;
            }
        }
    }
}

