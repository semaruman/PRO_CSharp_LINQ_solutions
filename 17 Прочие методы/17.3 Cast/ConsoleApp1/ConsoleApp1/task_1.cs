static class Ex
{
    public static List<char> MyCast(this string word)
    {
        // реализовать логику
        List<char> list = new List<char>();
        foreach (char c in word)
        {
            list.Add(c);
        }
        return list;
    }
}