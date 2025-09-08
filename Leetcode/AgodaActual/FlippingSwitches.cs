using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AgodaActual;

public class FlippingSwitches
{
    public int FinalState(int[][] operations)
    {
        bool[] nums = new bool[7];

        foreach (int[] operation in operations)
        {
            int start = operation[0];
            int end = operation[1];

            while (start < end)
            {
                nums[start] = !nums[start];
                start++;
            }
        }

        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == true)
            {
                result += i;
            }
        }

        return result;
    }
}
