using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public int Rating { get; set; }


        public Item(string name, string type, int cost, int rating)
        {
            Name = name;
            Type = type;
            Cost = cost;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name}: {Cost}, {Rating}";
        }
    }
    class Program6
    {
        static void Main()
        {
            var items = new List<Item>
            {
                new Item("22032 Fillips", "Телевизор", 2500, 4),
                new Item("22W37 ShangTsung", "Телевизор", 3000, 5),
                new Item("1005L 3G", "Телевизор", 4000, 3),
                new Item("15Q BiQ", "Телевизор", 5000, 4),

                new Item("7700 Soni", "Телефон", 2500, 5),
                new Item("10X Epple", "Телефон", 70000, 5),
                new Item("MI5 Ksaome", "Телефон", 5100, 4),
                new Item("2AP7 ShangTsung", "Телефон", 8900, 4),

                new Item("1121 Cefal", "Пылесос", 5000, 4),
                new Item("VC53 3G", "Пылесос", 4500, 5),
                new Item("F214 Borsch", "Пылесос", 6000, 5),
                new Item("RV32 Bredmond", "Пылесос", 7800, 3),

                new Item("2H12 Hawaii", "Ноутбук", 25000, 5),
                new Item("HK23 Oasis", "Ноутбук", 20000, 4),
                new Item("P92 HB", "Ноутбук", 21000, 5),
                new Item("VO2219 Lenoblo", "Ноутбук", 27000, 3),
            };

            string type = Console.ReadLine();
            string sorting = Console.ReadLine();
            // Продолжите здесь

            List<Item> sortedList = new List<Item>();

            if (sorting == "1")
            {
                sortedList = items.Where(item => item.Type == type).OrderBy(item => item.Cost/item.Rating).ToList();
            }
            else if (sorting == "2")
            {
                sortedList = items.Where(item => item.Type == type).OrderBy(item => item.Cost).ToList();
            }
            else if (sorting == "3")
            {
                sortedList = items.Where(item => item.Type == type).OrderByDescending(item => item.Cost).ToList();
            }
            else if (sorting == "4")
            {
                sortedList = items.Where(item => item.Type == type).OrderByDescending(item => item.Rating).ToList();
            }

            foreach (Item item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}