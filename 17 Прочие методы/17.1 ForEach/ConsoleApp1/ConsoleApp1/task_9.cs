using System;
using System.Collections.Generic;
using System.Linq;

public class Program9
{
    public static void Main9()
    {
        List<Action> actions = new List<Action>
{
    () => Console.Write("Hello "),
    () => Console.Write("World"),
    () => Console.Write("!")
};
        actions.ForEach(action => action());
    }
}