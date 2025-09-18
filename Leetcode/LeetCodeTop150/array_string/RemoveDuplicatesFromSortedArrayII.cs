using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class RemoveDuplicatesFromSortedArrayII
{
    //[0,0,1,1,2,3,2,3,3]
    //j = 6
    //total = 2
    //i = 8
    public int RemoveDuplicates2(int[] nums)
    {
        int j = 1;
        int total = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i])
            {
                if (total >= 2)
                {
                    total++;
                    continue;
                }

                nums[j] = nums[i];
                total++;
                j++;
            }
            else
            {
                nums[j] = nums[i];
                total = 1;
                j++;
            }
        }

        return j;
    }









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
