using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        //[1,2,3,4]
        //prefix product [1,2,6,24]
        //suffix product [24,24,12,4]

        int[] result = new int[nums.Length];
        int postTotal = 1;
        for(int i = nums.Length - 1;  i >= 0; i--)
        {
            postTotal = postTotal * nums[i];
            result[i] = postTotal;
            Console.Write($"index: {i} = total: {postTotal}");
        }

        int preTotal = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == nums.Length - 1)
            {
                result[i] = preTotal;
                continue;
            }

            if(i == 0)
            {
                result[i] = result[result.Length - 2];
            }

            result[i] = preTotal * result[i + 1];

            preTotal = preTotal * nums[i];
            Console.WriteLine($"PreTotal: {preTotal}, result at {result.Length - 1 - 1} = {result[result.Length - 1 - i]} index: {i}");
            Console.WriteLine($"Result Value: {result[i]}");
        }

        return result;
    }
}
