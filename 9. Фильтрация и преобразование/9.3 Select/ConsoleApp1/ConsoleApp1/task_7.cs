public class ProductDb
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public decimal Cost { get; set; }

    public string Description { get; set; }

    public string ImagePath { get; set; }
}
public class ProductViewModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public decimal Cost { get; set; }

    static IEnumerable<ProductViewModel> ToProductViewModels(IEnumerable<ProductDb> db)
    {
        return db.Select(p => new ProductViewModel { Id = p.Id, Name = p.Name, Cost = p.Cost });
    }
}

