using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Stack;

//[4, 3, 2]
//[0, 1, 2]

public class MinStack
{
    private Stack<int> _stack { get; set; }
    private Stack<(int index, int value)> _lowestIndex { get; set; }

    public MinStack()
    {
        _stack = new Stack<int>();
        _lowestIndex = new Stack<(int index, int value)>();
    }

    public void Push(int val)
    {
        if(_lowestIndex.Count == 0 || val < _lowestIndex.Peek().value)
        {
            _lowestIndex.Push((_stack.Count, val));
        }

        _stack.Push(val);
    }

    public void Pop()
    {
        _stack.Pop();

        if(_stack.Count - 1 < _lowestIndex.Peek().index)
        {
            _lowestIndex.Pop();
        }
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _lowestIndex.Peek().value;
    }
}
