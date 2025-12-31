public class FrozenFood
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public FrozenFood(string name, int сost)
    {
        Name = name;
        Cost = сost;
    }
}
public class Dumplings : FrozenFood
{
    public Dumplings(string name, int сost) : base(name, сost) { }
}

public class Meatball : FrozenFood
{
    public Meatball(string name, int сost) : base(name, сost) { }
}

public class Steaks : FrozenFood
{
    public Steaks(string name, int сost) : base(name, сost) { }
}

public class Program2
{
    public static void Main2()
    {
        var foods = new List<FrozenFood>();
        var str = Console.ReadLine();
        while (!string.IsNullOrEmpty(str))
        {
            var product = str.Split(", ");
            switch (product[0])
            {
                case "Пельмени":
                    foods.Add(new Dumplings(product[1], int.Parse(product[2])));
                    break;
                case "Фрикадельки":
                    foods.Add(new Meatball(product[1], int.Parse(product[2])));
                    break;
                case "Стейки":
                    foods.Add(new Steaks(product[1], int.Parse(product[2])));
                    break;
            }
            str = Console.ReadLine();
        }

        var dumplings = GetDumplings(foods);

        foreach (var item in dumplings)
        {
            Console.WriteLine(item.Name + " " + item.Cost);
        }
    }
    static IEnumerable<Dumplings> GetDumplings(IEnumerable<FrozenFood> foods)
    {
        // реализовать логику
        return foods.OfType<Dumplings>();
    }
}