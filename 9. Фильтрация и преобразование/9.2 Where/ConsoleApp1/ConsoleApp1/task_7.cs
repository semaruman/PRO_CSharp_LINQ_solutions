class Country
{
    public int Id { get; set; }

    // Название страны
    public string Name { get; set; }

    // Столица
    public string Capital { get; set; }

    // Численность населения
    public long Population { get; set; }

    static IEnumerable<Country> GetBigCountries(IEnumerable<Country> countries)
    {
        // реализовать логику
        return countries.Where(country => country.Population >= 1000000 && country.Population <= 5000000);
    }
}