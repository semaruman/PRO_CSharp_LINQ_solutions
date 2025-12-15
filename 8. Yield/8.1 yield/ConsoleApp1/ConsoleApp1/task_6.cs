class Program6
{

    static int n = 0;

    static IEnumerable<int> Numbers
    {
        get
        {
            for (int i = n; i > 0; i--)
            {
                yield return i;
            }
            for (int i = 0; i <= n; i++)
            {
                yield return i;
            }
        }
    }

    static void Main6()
    {

        n = int.Parse(Console.ReadLine());

        foreach (var number in Numbers)
        {
            Console.WriteLine(number);
        }
    }
}