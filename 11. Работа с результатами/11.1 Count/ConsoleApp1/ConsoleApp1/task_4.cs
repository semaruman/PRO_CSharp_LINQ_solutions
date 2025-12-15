using System;
using System.Linq;

namespace LINQ
{
    class Program4
    {
        static void Main4()
        {
            string input = Console.ReadLine();

            var res = input.Count(c => char.IsLetter(c));

            Console.WriteLine(res);
        }
    }
}