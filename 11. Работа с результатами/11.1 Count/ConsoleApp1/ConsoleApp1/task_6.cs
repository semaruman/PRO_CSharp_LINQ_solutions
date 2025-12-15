class PowerOutlet
{
    //Название розетки
    public string Name { get; set; }

    //Флаг указывающий с заземлением ли розетка
    public bool Grounding { get; set; }
}

public class Program6
{
    public static void Main6()
    {
        var powerOutlets = new List<PowerOutlet>()
{
    new PowerOutlet{Name = "Legrand0", Grounding = true},
    new PowerOutlet{Name = "TDM0", Grounding = false},
    new PowerOutlet{Name = "IEK0", Grounding = true},
    new PowerOutlet{Name = "Schneider0", Grounding = false},
    new PowerOutlet{Name = "Legrand1", Grounding = true},
    new PowerOutlet{Name = "TDM1", Grounding = false},
    new PowerOutlet{Name = "IEK1", Grounding = true},
    new PowerOutlet{Name = "Schneider1", Grounding = false}
};
    }
    static int GetLengthWire(List<PowerOutlet> powerOutlets)
    {
        return powerOutlets.Count(po => po.Grounding) * 5;
    }
}