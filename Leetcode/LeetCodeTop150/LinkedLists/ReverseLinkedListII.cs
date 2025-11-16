using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class ReverseLinkedListII
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode before = dummy;
        for (int i = 1; i < left; i++)
        {
            before = before.next;
        }

        ListNode prev = before;
        ListNode curr = before.next;
        for (int i = left; i <= right; i++)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        before.next.next = curr;
        before.next = prev;

        return dummy.next;
    }

}
