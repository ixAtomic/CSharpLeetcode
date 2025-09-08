using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150;

public class RemoveDuplicatesFromSortedArrayII
{
    //[1,1,1,2,2,3]
    public int RemoveDuplicates(int[] nums)
    {
        int count = 1;
        int j = 0;

        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if(count <= 2)
            {
                j++;
            }

            nums[j] = nums[i];
        }

        return j + 1;
    }
}
