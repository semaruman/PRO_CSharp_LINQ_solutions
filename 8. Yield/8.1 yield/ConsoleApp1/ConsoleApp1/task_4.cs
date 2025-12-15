public class Task4
{
    static IEnumerable<string> GetInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Стоп")
            {
                yield break;
            }
            yield return input;
        }
    }
}