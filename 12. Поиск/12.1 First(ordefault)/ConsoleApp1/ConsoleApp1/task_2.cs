class Country
{
    public int Id { get; set; }

    // Название страны
    public string Name { get; set; }

    // Столица
    public string Capital { get; set; }

    // Численность населения
    public long Population { get; set; }

    public override string ToString()
    {
        return $"{Name} {Population}";
    }
}

public class Program2
{
    public static void Main2()
    {
        var countries = new List<Country> { new Country { Name = "Country1", Population = 100000 } };
        var result = TryGetDwarfCountry(countries);
        Console.WriteLine(result);
    }
    static Country TryGetDwarfCountry(IEnumerable<Country> countries)
    {
        // реализовать логику

        return countries.Where(country => country.Population <=100000).FirstOrDefault();
    }
}