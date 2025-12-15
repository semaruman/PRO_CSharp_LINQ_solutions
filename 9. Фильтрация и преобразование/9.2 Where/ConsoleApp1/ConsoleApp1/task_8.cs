public class Child
{
    //полное имя
    public string FullName { get; set; }

    //уменьшительно-ласкательное имя
    public string DiminutiveName { get; set; }

    static IEnumerable<Child> GetShortName(IEnumerable<Child> children)
    {
        return children.Where(child => child.FullName.Length >= child.DiminutiveName.Length);
    }
}