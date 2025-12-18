using System;
using System.Linq;
using System.Collections.Generic;

public class Detail
{
    public int Id { get; set; }
    public bool Defective { get; set; }

    public Detail(int id, bool defective)
    {
        Id = id;
        Defective = defective;
    }
}

public class MainClass4
{
    public static void Main()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());
        List<Detail> details = new List<Detail>();

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split();
            int id = Convert.ToInt32(temp[0]);
            bool defective = Convert.ToBoolean(temp[1]);

            details.Add(new Detail(id, defective));
        }

        Console.WriteLine(string.Join(", ", details.TakeWhile(detail => detail.Defective == false).Select(detail => detail.Id)));
    }
}