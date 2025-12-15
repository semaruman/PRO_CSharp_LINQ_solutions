using System.Linq;
public class Program
{
    public static void Main()
    {
        var names = new List<string> { "Ио", "Марк", "Роксана", "Светлана" };
        foreach (var name in GetLongNames(names))
            Console.WriteLine(name);

    }
    static List<string> GetLongNames(List<string> names)
    {
        return names.Where(name => name.Length > 3).Select(name => name).ToList();
    }
}
