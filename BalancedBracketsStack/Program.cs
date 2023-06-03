// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

public class BalancedBrackets
{
    public static bool CheckBalance(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (IsOpeningBracket(c))
            {
                stack.Push(c);
            }
            else if (IsClosingBracket(c))
            {
                if (stack.Count == 0 || !IsMatchingBracket(stack.Peek(), c))
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }

    private static bool IsOpeningBracket(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }

    private static bool IsClosingBracket(char c)
    {
        return c == ')' || c == ']' || c == '}';
    }

    private static bool IsMatchingBracket(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}');
    }

    public static void Main(string[] args)
    {
        string input = "({[()]})";
        bool isBalanced = CheckBalance(input);
        Console.WriteLine("The input string is balanced: " + isBalanced);
    }
}
