using System;
using System.Collections.Generic;

public class ProgramTemp
{
    public static void MainTemp()
    {
        string scob = Console.ReadLine();

        bool flag = true;

        string openScob = "([{<";


        Stack<char> stack = new Stack<char>();
        stack.Push(scob[0]);
        for (int i = 1; i < scob.Length; i++)
        {
            if (openScob.Contains(scob[i]))
            {
                stack.Push(scob[i]);
                continue;
            }

            if (openScob.Contains(stack.Peek()))
            {
                if (TrueScob(stack.Peek(), scob[i]))
                {
                    stack.Pop();
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            else
            {
                flag = false;
                break;
            }
        }

        if (stack.Count > 0)
        {
            flag = false;
        }

        Console.WriteLine(flag?"True":"False");
    }
    static bool TrueScob(char openS, char closeS)
    {
        if (openS == '(' && closeS == ')')
        {
            return true;
        }
        else if (openS == '[' && closeS == ']')
        {
            return true;
        }
        else if (openS == '{' && closeS == '}')
        {
            return true;
        }
        else if (openS == '<' && closeS == '>')
        {
            return true;
        }
        return false;
    }
}