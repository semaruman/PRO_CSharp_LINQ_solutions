using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program3
    {
        static void Main3()
        {
            var objects = new List<object> { 1, 2, "three", '8', 4, 5 };
            // ваш код начинается здесь
            var castObjects = objects.Where(x => x is int).Cast<int>();
            Console.WriteLine(string.Join(" ", castObjects));
        }
    }
}