public class Task5 {
    static bool? b = true;
    static IEnumerable<string> IsTrue()
    {
        while (true)
        {
            if (b == true)
            {
                yield return "Да";
            }
            else if (b == false)
            {
                yield return "Нет";
            }
            else
            {
                yield break;
            }
        }
    }
}