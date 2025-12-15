public class Program5
{
    public static void Main5(string[] args)
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

        int n = 1;// Convert.ToInt32(Console.ReadLine());

        var result = teams.SelectMany(
            (player, index) => player.Select(x => new { Name = player, Number = index++ }),
            (start, pl) => $"{start} играет в команде №{n} под номером {pl.Number + 1}"); 

        foreach (var playerInfo in result)
        {
            Console.WriteLine(playerInfo);
        }
    }
}