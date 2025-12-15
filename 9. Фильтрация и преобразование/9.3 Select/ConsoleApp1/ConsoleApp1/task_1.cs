public class Furniture
{
    public int Height { get; set; }
    public int Width { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public bool InStock { get; set; }
    static IEnumerable<Chair> GetChairs(IEnumerable<Furniture> furnitures)
    {
        // реализовать логику
        foreach (var f in furnitures)
        {
            if (f.Type == "Chair")
            {
                yield return new Chair(f.Manufacturer, f.Price);
            }
        }
    }
}
public class Chair
{
    public string Manufacturer { get; set; }
    public int Price { get; set; }

    public Chair(string manufacturer, int price)
    {
        Manufacturer = manufacturer;
        Price = price;
    }
}