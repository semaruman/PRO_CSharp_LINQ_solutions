public class Phone
{
    public string Name { get; set; }
    public decimal Cost { get; set; }

    public Phone(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}

public static class SumEx
{
    public static decimal MySum2(this IEnumerable<Phone> phones)
    {
        decimal sum = 0;
        foreach (Phone phone in phones)
        {
            sum += phone.Cost;
        }
        return sum;
    }
}

public class Program3
{
    static void Main3()
    {
        var phones = new Phone[]
        {
        new Phone("Iphone 13 mini", 70_000),
        new Phone("Honor 50 Light", 20_000)

        };

        var sum = phones.MySum2();
        Console.WriteLine(sum);
    }
}