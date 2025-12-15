class Retiree
{
    //Фамилия пенсионера
    public string Surname { get; set; }

    //Возраст пенсионера
    public int Age { get; set; }

    //Флаг, указывающий является ли пенсионер ветераном труда
    public bool LaborVeteran { get; set; }

    public Retiree(string surname, int age, bool laborVeteran)
    {
        Surname = surname;
        Age = age;
        LaborVeteran = laborVeteran;
    }
}

public class Program6
{
    public static void Main()
    {
        var retires = new List<List<Retiree>>
 {  
     // первое отделение
     new List<Retiree>
     {
         new Retiree("Иванов", 64, false),
         new Retiree("Петров", 65, false),
         new Retiree("Сидоров", 66, true)
     },

     //второе отделение
     new List<Retiree>
     {
         new Retiree("Пушкин", 72, true),
         new Retiree("Лермонтов", 66, false),
         new Retiree("Крылов", 89, true)
     },

     //третье отделение
     new List<Retiree>
     {
         new Retiree("Кипелов", 65, false),
         new Retiree("Цой", 62, true),
         new Retiree("Высоцкий", 86, true)
     }
 };

        var result = retires.SelectMany(
            (otdel, index) => otdel.Select(x => new { Number = index + 1 }),
            (retires, ot) => retires.Select(x => x.LaborVeteran ? $"Пенсионер {x.Surname} из {ot.Number} отделения получит прибавку к пенсии в размере {1500 + x.Age} рублей" : $"Пенсионер {x.Surname} из {ot.Number} отделения получит прибавку к пенсии в размере {500 + x.Age} рублей")
        );


        foreach (var person in result)
        {
            Console.WriteLine(person);
        }
    }
}