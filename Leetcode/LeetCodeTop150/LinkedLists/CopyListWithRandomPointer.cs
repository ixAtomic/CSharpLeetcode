using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class CopyListWithRandomPointer
{
    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;

        // 1. Interweave the original list and the copied list
        Node current = head;
        while (current != null)
        {
            Node temp = current.next;
            Node node = new Node(current.val);
            node.next = temp;
            current.next = node;
            current = temp;
        }

        // 2. Copy random pointers
        current = head;
        while (current != null)
        {
            if (current.next != null)
            {
                current.next.random = current.random != null ? current.random.next : null;
            }
            current = current.next?.next;
        }

        // 3. Separate the lists
        Node originalHead = head;
        Node copiedHead = head.next;
        Node copiedCurrent = copiedHead;

        while (originalHead != null)
        {
            originalHead.next = originalHead.next.next;
            copiedCurrent.next = copiedCurrent.next?.next; // Use null-conditional operator here
            originalHead = originalHead.next;
            copiedCurrent = copiedCurrent.next;
        }

        return copiedHead;
    }
}

public class Node
{
    public int val;
    public Node? next;
    public Node? random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}
