using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Agoda;

public class DailyTemperaturesSolution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] results = new int[temperatures.Length];
        Stack<(int val, int index)> values = new Stack<(int val, int index)>();

        for(int i = 0;  i < temperatures.Length; i++)
        {
            while (values.Any() && temperatures[i] > values.Peek().val)
            {
                var current = values.Pop();

                results[current.index] = i - current.index;
            }

            values.Push((temperatures[i], i));
        }

        return results;
    }
}
