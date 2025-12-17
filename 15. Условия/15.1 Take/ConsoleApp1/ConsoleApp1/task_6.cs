using System;
using System.Linq;
using System.Collections.Generic;

public class Flat
{
    // Название улицы
    public string Street { get; set; }

    // Номер дома
    public int HouseNumber { get; set; }

    // Площадь квартиры
    public int Area { get; set; }

    // Расстояние до автобусной остановки
    public int DistanceToBusStop { get; set; }

    // Наличие школы недалеко от квартиры
    public bool NearSchool { get; set; }

    // Наличие детского сада недалеко от квартиры
    public bool NearKindergarten { get; set; }

    // Стоимость
    public int Cost { get; set; }

    public Flat(string street, int houseNumber, int area, int distanceToBusStop, bool nearSchool, bool nearKindergarten, int cost)
    {
        Street = street;
        HouseNumber = houseNumber;
        Area = area;
        DistanceToBusStop = distanceToBusStop;
        NearSchool = nearSchool;
        NearKindergarten = nearKindergarten;
        Cost = cost;
    }
    public override string ToString()
    {
        return $"{Street} {HouseNumber}";
    }
}


public class Program6
{
    public static void Main6()
    {
        string s;
        List<Flat> list = new List<Flat>();

        while (true)
        {
            s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                break;
            }
            string[] temp = s.Split();
            list.Add(new Flat(temp[0], Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), Convert.ToBoolean(temp[4]), Convert.ToBoolean(temp[5]), Convert.ToInt32(temp[6])));
        }
        List<Flat> flats = list.Where(flat => flat.NearSchool==true && flat.NearKindergarten==true && flat.DistanceToBusStop < 1000).OrderByDescending(flat => flat.Area).ThenBy(flat => flat.Cost).Take(3).ToList();
        Console.WriteLine(string.Join("\n", flats));
    }
}