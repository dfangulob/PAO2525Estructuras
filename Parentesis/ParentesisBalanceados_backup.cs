using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la expresión matemática:");
        string expression = Console.ReadLine();

        bool isBalanced = AreParenthesesBalanced(expression);

        if (isBalanced)
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula no balanceada.");
    }

    static bool AreParenthesesBalanced(string expr)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in expr)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if (!IsMatchingPair(top, c))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    static bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}
