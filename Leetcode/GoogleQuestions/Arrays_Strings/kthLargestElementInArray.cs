using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions.Arrays_Strings;

class kthLargestElementInArray
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        foreach(var value in nums)
        {
            queue.Enqueue(value, value);
            if(queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        return queue.Dequeue();
    }
}
