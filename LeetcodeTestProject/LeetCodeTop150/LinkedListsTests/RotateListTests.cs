using System.Collections.Generic;
using LeetCode;
using LeetCode.LeetCodeTop150.LinkedLists;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.LinkedListsTests;

public class RotateListTests
{
    private static ListNode BuildList(int[] values)
    {
        var dummy = new ListNode(0, null);
        var tail = dummy;
        foreach (var v in values)
        {
            tail.next = new ListNode(v, null);
            tail = tail.next;
        }
        return dummy.next;
    }

    private static int[] ToArray(ListNode head)
    {
        var list = new List<int>();
        var cur = head;
        while (cur != null)
        {
            list.Add(cur.val);
            cur = cur.next;
        }
        return list.ToArray();
    }

    [Fact]
    public void RotateRight_K2_ShiftsRightBy2()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new RotateList();

        var result = solver.RotateRight(head, 2);

        Assert.Equal(new[] { 4, 5, 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void RotateRight_K0_NoChange()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var solver = new RotateList();

        var result = solver.RotateRight(head, 0);

        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void RotateRight_KMultipleOfLength_NoChange()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new RotateList();

        var result = solver.RotateRight(head, 10); // 10 % 5 == 0

        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ToArray(result));
    }

    [Fact]
    public void RotateRight_KGreaterThanLength_UsesMod()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new RotateList();

        var result = solver.RotateRight(head, 8); // 8 % 5 == 3

        Assert.Equal(new[] { 3, 4, 5, 1, 2 }, ToArray(result));
    }

    [Fact]
    public void RotateRight_SingleNode_NoChange()
    {
        var head = BuildList(new[] { 42 });
        var solver = new RotateList();

        var result = solver.RotateRight(head, 100);

        Assert.Equal(new[] { 42 }, ToArray(result));
    }

    [Fact]
    public void RotateRight_EmptyList_ReturnsNull()
    {
        ListNode head = null;
        var solver = new RotateList();

        var result = solver.RotateRight(head, 5);

        Assert.Null(result);
    }
}
