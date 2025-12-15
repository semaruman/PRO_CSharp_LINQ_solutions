class Patient
{
    //Фамилия пациента
    public string Surname { get; set; }

    //Флаг, показывающий есть ли льгота у пациента
    public bool Privilege { get; set; }
}

public class Program7
{
    public static void Main()
    {
        var patients = new List<Patient>
    {
        new Patient {Surname = "Петров", Privilege = false },
        new Patient {Surname = "Иванов", Privilege = true }
    };

        var firstPatient = TryGetNextPatient(patients);
        Console.WriteLine(firstPatient);
    }
    static string TryGetNextPatient(List<Patient> patients)
    {
        //реализовать логику
        try
        {
            return patients.Where(patient => patient.Privilege).First().Surname;
        }
        catch
        {
            try
            {
                return patients.First().Surname;
            }
            catch
            {
                return "Пациентов в очереди нет";
            }
        }
    }
}