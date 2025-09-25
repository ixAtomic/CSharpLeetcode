using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.TwoPointers;

public class TwoSumIISortedInputArray
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int i = 0;
        int j = numbers.Length - 1;
        while(i < j)
        {
            int sum = numbers[i] + numbers[j];
            if (sum == target)
            {
                return [i + 1, j + 1];
            }
            else if (sum > target)
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return [];
    }
}
