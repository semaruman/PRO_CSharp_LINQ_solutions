static class Ex
{
    public static void MyForEach(this List<string> peoples)
    {
        // реализовать логику
        foreach (var people in peoples)
        {
            Console.WriteLine($"HI {people}");
        }
    }
}