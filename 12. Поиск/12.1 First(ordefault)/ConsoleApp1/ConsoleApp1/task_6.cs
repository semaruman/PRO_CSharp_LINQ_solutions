public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"{Id}, {Name}";
    }
}

public class User
{
    public string Name { get; set; }
    public Product[] Products { get; set; }

    public User(string name, Product[] products)
    {
        Name = name;
        Products = products;
    }
}

public class Program6
{
    public static void Main6()
    {
        var products = new Product[]
        {
        new Product(1, "Prod1"),
        new Product(2, "Prod2"),
        new Product(3, "Prod3")
        };

        var user1 = new User("User1", products);
        var users = new List<User>
    {
        user1
    };
        var result = TryGetUserProducts(users, "User1");
        Console.WriteLine(string.Join(" ", (IEnumerable<Product>)result));
    }
    static Product[] TryGetUserProducts(IEnumerable<User> users, string userName)
    {
        // реализовать логику
        try
        {
            return users.Where(user => user.Name == userName).First().Products;
        }
        catch
        {
            return null;
        }
    }
}