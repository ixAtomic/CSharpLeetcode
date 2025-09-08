using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Agoda;

public class _3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums); //onlogn
        Dictionary<int, int> set = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) //on
        {
            if (set.ContainsKey(nums[i]))
            {
                set[nums[i]]++;
                continue;
            }

            set.Add(nums[i], 1);
        }

        IList<IList<int>> results = new List<IList<int>>();
        for(int i = 0; i < nums.Length - 1; i++) //on
        {
            var current = nums[i] + nums[i + 1];
            var inverse = current * -1;

            if (nums[i + 1] > inverse) continue;

            if (!set.ContainsKey(inverse)) continue;

            results.Add([nums[i], nums[i + 1], inverse]);
        }

        return results;
    }
}
