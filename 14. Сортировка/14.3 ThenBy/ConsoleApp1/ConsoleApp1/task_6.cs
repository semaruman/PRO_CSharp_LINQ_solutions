using System;
using System.Linq;
using System.Collections.Generic;

namespace task6
{
    public class Number
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public Number(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class MainClass6
    {
        public static void Main6()
        {
            // put your c# code here

            List<Number> numbers = new List<Number>();

            for (int i = 0; i < 3; i++)
            {
                string[] temp = Console.ReadLine().Split();
                numbers.Add(new Number(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1])));
            }
            numbers = numbers.OrderBy(x => x.Key).ThenByDescending(x => x.Value).ToList();

            foreach (Number n in numbers)
            {
                Console.WriteLine($"{n.Key} {n.Value}");
            }
        }
    }
}