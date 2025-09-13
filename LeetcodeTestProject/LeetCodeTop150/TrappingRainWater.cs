using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTestProject.LeetCodeTop150;

public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int total = 0;
        while(left < right)
        {
            if (height[left] < height[right])
            {
                maxLeft = maxLeft > height[left] ? maxLeft : height[left];
                total += maxLeft - height[left];
                left++;
            }
            else
            {
                maxRight = maxRight > height[right] ? maxRight : height[right];
                total += maxRight - height[right];
                right--;
            }
        }

        return total;
    }
}
