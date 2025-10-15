using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Stack;

public class EvaluateReversePolishNotation
{
    List<string> operations = ["+", "-", "*", "/"];
    public int EvalRPN(string[] tokens)
    {
        Stack<int> values = new Stack<int>();
        foreach (var item in tokens)
        {
            if (operations.Contains(item))
            {
                int second = values.Pop();
                int first = values.Pop();
                switch (item)
                {
                    case "+":
                        values.Push(first + second);
                        break;
                    case "-":
                        values.Push(first - second);
                        break;
                    case "*":
                        values.Push(first * second);
                        break;
                    case "/":
                        values.Push(first / second);
                        break;
                }
            }
            else
            {
                values.Push(int.Parse(item));
            }
        }

        return values.Pop();
    }
}
