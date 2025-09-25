using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.TwoPointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int maxVolume = 0;
        int i = 0;
        int j = height.Length - 1;

        while(i < j)
        {
            int width = j - i;
            int volume = height[i] > height[j] ? height[j] * width : height[i] * width;
            maxVolume = Math.Max(maxVolume, volume);

            if (height[i] > height[j])
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return maxVolume;
    }
}
