public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }


    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
public class BasketPosition
{
    public Product Product { get; set; }
    public int Amount { get; set; }

    public BasketPosition(Product product, int amount)
    {
        Product = product;
        Amount = amount;
    }
}

public class Basket
{
    public int Id { get; set; }
    public List<BasketPosition> Positions { get; set; }

    public int ProductsAmount
    {
        get
        {
            return Positions.Sum(x => x.Amount);
        }
    }

    public Basket(int id, List<BasketPosition> positions)
    {
        Id = id;
        Positions = positions;
    }
}