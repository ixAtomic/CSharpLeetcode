using LeetCode.Agoda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class RemoveNthNodeFromEndOfList
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);

        ListNode before = dummy;
        ListNode curr = dummy.next;
        int count = 1;
        while(curr != null)
        {
            if (count > n)
            {
                before = before.next;
            }

            curr = curr.next;
            count++;
        }
        
        before.next = before.next.next;

        return dummy.next;
    }
}
