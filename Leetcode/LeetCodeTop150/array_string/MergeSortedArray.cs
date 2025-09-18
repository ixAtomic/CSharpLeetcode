using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class MergeSortedArray
{
    //[4, 5, 6, 0, 0, 0], m = 3
    //[1, 2, 3], n = 3

    //[1, 2, 3, 0, 0, 0], m = 3
    //[4, 5, 6], n = 3

    //[1, 2, 2, 0, 0, 0], m = 3
    //[3, 5, 6], n = 3

    //[1], m = 1
    //[], n = 0


    public void MergeSecond(int[] nums1, int m, int[] nums2, int n)
    {
        int p = m + n;
        m--;
        n--;
        for(int i = p - 1; i >= 0; i--)
        {
            if(n < 0)
            {
                break;
            }

            if (m >= 0 && nums1[m] > nums2[n])
            {
                nums1[i] = nums1[m--];
            }
            else
            {
                nums1[i] = nums2[n--];
            }
        }
    }


    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if(nums2.Length == 0)
        {
            return;
        }

        int i = 0;
        int j = 0;
        while(i + j < m + n)
        {
            if (nums1[i] > nums2[j])
            {
                int temp = nums2[j];
                nums2[j] = nums1[i];
                nums1[i] = temp;

                i++;
            }
            else if (nums2[j] > nums1[i])
            {
                int temp = nums2[j];
                nums2[j] = nums1[i];
                nums1[i] = temp;

                j++;
            }
            else
            {
                i++;
            }
        }
    }
}
