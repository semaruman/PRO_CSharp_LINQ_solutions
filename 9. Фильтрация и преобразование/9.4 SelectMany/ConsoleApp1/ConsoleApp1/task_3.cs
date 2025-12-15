public class File
{
    public List<string> Rows { get; set; }

    public File(List<string> rows)
    {
        Rows = rows;
    }
}

public class Program3
{
    static void Main3()
    {
        var files = new List<File>
    {
        new File
        (
            new List<string>
            {
                "1",
                "слово",
                "-2",
                "-c"
            }
            ),
        new File
        (
            new List<string>
            {
                "83",
                " ",
                "aaaaa",
                "quququq"
            }
            ),

        new File
        (
            new List<string>
            {
                "90",
                "slskdjf23l",
                "13",
                "n"
            }
            )
    };
        var inputNumbers = GetNumbers(files);

        Console.WriteLine(string.Join(" ", inputNumbers));
    }
    static IEnumerable<string> GetNumbers(List<File> files)
    {
        // реализовать логику
        return files.SelectMany(file => file.Rows.Where(row => int.TryParse(row, out int _)).ToList());
    }
}