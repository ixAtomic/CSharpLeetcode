using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class RotateList
{
    //really should make a ring and then figure out the correct head and tail that way
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0) return head;

        int length = 0;
        ListNode curr = head;
        while(curr != null)
        {
            curr = curr.next;
            length++;
        }

        if (k % length == 0) return head;

        ListNode prev = null;
        curr = head;
        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        ListNode dummy = new ListNode(0, prev);
        ListNode before = dummy;
        prev = dummy;
        curr = dummy.next;
        int actual = k % length;

        int count = 0;
        while(count < actual)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
            count++;
        }

        before.next.next = curr;
        ListNode temp = before.next;
        before.next = prev;
        before = temp;

        prev = before;
        curr = before.next;
        while(curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        before.next.next = null;
        before.next = prev;

        return dummy.next;
    }
}
