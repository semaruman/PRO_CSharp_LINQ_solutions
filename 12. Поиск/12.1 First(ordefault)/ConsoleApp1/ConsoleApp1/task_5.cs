public class City
{
    public string Name { get; set; }
    public int CitizensCount { get; set; }

    public City(string name, int citizensCount)
    {
        CitizensCount = citizensCount;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name}, {CitizensCount}";
    }
}
public class MainClass5
{
    public static void Main5()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());
        List<City> list = new List<City>();
        for (int _ = 0; _ < n; _++)
        {
            string[] s = Console.ReadLine().Split(", ");
            list.Add(new City(s[0], Convert.ToInt32(s[1])));
        }
        int count = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine(list.First(city => city.CitizensCount > count));
        }
        catch
        {
            Console.WriteLine("Нет");
        }
    }
}