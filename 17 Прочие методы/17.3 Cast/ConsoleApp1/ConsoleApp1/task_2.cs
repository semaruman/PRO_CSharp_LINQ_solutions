using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program2
    {
        enum Colors
        {
            White = 1,
            Yellow = 3,
            Blue = 4
        };
        static void Main2()
        {
            var colors = new List<Colors> { Colors.White, Colors.Yellow, Colors.Blue };
            // ваш код начинается здесь
            Console.WriteLine(string.Join(",", colors.Cast<int>()));
        }
    }
}