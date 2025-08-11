using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class _4SumII
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for(int i = 0; i < nums1.Length; i++)
        {
            for(int j = 0; j < nums2.Length; j++)
            {
                var value = nums1[i] + nums2[j];
                if (result.ContainsKey(value))
                {
                    result[value]++;
                }
                else
                {
                    result.Add(value, 1);
                }
            }
        }

        int count = 0;
        for(int i = 0; i < nums3.Length; i++)
        {
            for(int j = 0; j < nums4.Length; j++)
            {
                var value = -(nums3[i] + nums4[j]);
                if (result.ContainsKey(value))
                {
                    count = count + result[value];
                }
            }
        }

        return count;
    }
}
