public class Task3
{
    static IEnumerable<string> GetColorOfLine()
    {
        while (true)
        {
            yield return "Черное";
            yield return "Белое";
        }
    }
}