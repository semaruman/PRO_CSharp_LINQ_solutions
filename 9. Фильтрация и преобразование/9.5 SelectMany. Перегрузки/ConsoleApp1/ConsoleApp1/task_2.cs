public class Program2
{
    public static void Main2()
    {
        List<string[]> teams = new List<string[]>
            {
                new string[]{"Лионель Месси", "Криштиану Роналду", "Златан Ибрагимович", "Роберт Левандовский"},
//команда 1
                new string[]{"Мохаммед Салах", "Паоло Мальдини", "Франц Беккенбауэр", "Мишель Платини"},
//команда 2
                new string[]{"Йохан Кройф", "Лев Яшин", "Дэвид Бэкхем", "Диего Марадона"} 
//команда 3
            };

        string l = Console.ReadLine();

        var result = teams.SelectMany((team, index) => team.Where(player => player.Split(' ')[1].ToLower().StartsWith(l)).Select(p => new { Name = p, TeamNumber = index + 1}));

        foreach (var player in result)
        {
            Console.WriteLine($"Команда номер {player.TeamNumber}, {player.Name}");
        }
    }
}