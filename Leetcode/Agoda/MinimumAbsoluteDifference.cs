using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Agoda
{
    public class MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);

            int minDifference = int.MaxValue;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int difference = arr[i + 1] - arr[i];

                if(difference < minDifference)
                {
                    minDifference = difference;
                }
            }

            IList<IList<int>> results = new List<IList<int>>();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int difference = arr[i + 1] - arr[i];

                if(difference == minDifference)
                {
                    results.Add([arr[i], arr[i + 1]]);
                }
            }

            return results;
        }
    }
}
