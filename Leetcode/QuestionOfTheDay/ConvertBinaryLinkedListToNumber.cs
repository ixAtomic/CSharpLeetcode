using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionOfTheDay;


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}


public class ConvertBinaryLinkedListToNumber
{
    public int GetDecimalValue(ListNode head)
    {
        int result = 0;
        var current = head;
        while (current is not null)
        {
            result = (result << 1) | current.val; // Shift left and add current value
            current = current.next;
        }

        return result;
    }
}
