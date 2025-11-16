using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class LRUCache
{
    private int Capacity { get; set; }
    private Dictionary<int, LRUNode> Nodes { get; set; }
    private LRUNode Head = new LRUNode(-1, -1);
    private LRUNode Tail = new LRUNode(-1, -1);


    public LRUCache(int capacity)
    {
        Capacity = capacity;
        Nodes = new Dictionary<int, LRUNode>();
        Head.Next = Tail;
        Tail.Prev = Head;
    }

    public int Get(int key)
    {
        if(Nodes.TryGetValue(key, out LRUNode node))
        {
            Remove(node);
            Add(node);
            return node.Value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        var exists = Nodes.TryGetValue(key, out LRUNode node);

        if(exists)
        {
            Remove(node);
        }

        LRUNode newNode = new LRUNode(key, value);
        Nodes[key] = newNode;
        Add(newNode);

        if(Nodes.Count > Capacity)
        {
            var nodeToDelete = Head.Next;
            Remove(nodeToDelete);
            Nodes.Remove(nodeToDelete.Key);
        }
    }

    private void Add(LRUNode node)
    {
        var previousEnd = Tail.Prev;
        previousEnd.Next = node;
        node.Prev = previousEnd;
        node.Next = Tail;
        Tail.Prev = node;
    }

    private void Remove(LRUNode node)
    {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }
}

public class LRUNode
{
    public int Key { get; set; }
    public int Value { get; set; }
    public LRUNode Prev { get; set; }
    public LRUNode Next { get; set; }

    public LRUNode(int key, int value, LRUNode prev = null, LRUNode next = null)
    {
        Key = key; Value = value; Prev = prev; Next = next;
    }
}

