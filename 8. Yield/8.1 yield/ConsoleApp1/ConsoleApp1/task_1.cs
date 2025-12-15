using System.Numerics;

public class FibonacciCounter
{
    public void Count(long x)
    {
        var fibonacciNumbers = GetFibonacciNumbers(x);

        foreach (var number in fibonacciNumbers)
        {
            Console.WriteLine(number);
        }
    }
    private static List<BigInteger> GetFibonacciNumbers(long input)
    {
        List<BigInteger> fibonacciNumbers = new List<BigInteger>();

        BigInteger a0 = 0;
        BigInteger a1 = 1;

        for (int i = 0; i < input; i++)
        {
            if (i == 0)
            {
                fibonacciNumbers.Add(a0);
                continue;
            }
            else if (i == 1)
            {
                fibonacciNumbers.Add(a1);
                continue;
            }

            fibonacciNumbers.Add(a0 + a1);
            BigInteger temp = a0;
            a0 = a1;
            a1 = temp + a1;

        }
        return fibonacciNumbers;
    }
}

public class Program1
{
    public static void Main1()
    {
        var fibonachi = new FibonacciCounter();
        fibonachi.Count(1);

    }
}