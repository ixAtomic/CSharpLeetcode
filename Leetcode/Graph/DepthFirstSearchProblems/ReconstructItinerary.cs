using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DepthFirstSearchProblems;

class ReconstructItinerary
{
    private Dictionary<string, List<string>> adjacencyList = new Dictionary<string, List<string>>();
    private Dictionary<string, List<bool>> usedTickets = new Dictionary<string, List<bool>>();
    private LinkedList<string> result = new();
    private int ticketCount;

    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        ticketCount = tickets.Count;
        foreach (var ticket in tickets)
        {
            var start = ticket.ElementAt(0);
            var end = ticket.ElementAt(1);
            if (!adjacencyList.ContainsKey(start))
            {
                adjacencyList[start] = new List<string>();
                usedTickets[start] = new List<bool>();
            }
            adjacencyList[start].Add(end);
            usedTickets[start].Add(false);
        }

        foreach (var key in adjacencyList.Keys)
        {
            adjacencyList[key].Sort();
        }

        result.AddLast("JFK");
        Backtrack("JFK");

        return result.ToList();
    }

    private bool Backtrack(string currentNode)
    {
        if (result.Count == ticketCount + 1)
        {
            return true;
        }

        if (!adjacencyList.ContainsKey(currentNode))
        {
            return false;
        }

        for (int i = 0; i < adjacencyList[currentNode].Count; i++)
        {
            var neighbor = adjacencyList[currentNode][i];
            if (!usedTickets[currentNode][i])
            {
                usedTickets[currentNode][i] = true;
                result.AddLast(adjacencyList[currentNode][i]);
                if (Backtrack(adjacencyList[currentNode][i]))
                {
                    return true;
                }
                result.RemoveLast();
                usedTickets[currentNode][i] = false;
            }
        }

        return false;
    }


    // Graph representation: maps each airport to a min-heap (priority queue) of destinations for lexical order
    private Dictionary<string, PriorityQueue<string, string>> graph = new();
    // Stores the final itinerary in reverse (will be reversed at the end)
    private LinkedList<string> itinerary = new();

    public IList<string> FindItinerary2(IList<IList<string>> tickets)
    {
        // Step 1: Build the graph
        // For each ticket, add the destination to the min-heap of the departure airport
        // This ensures we always visit the lexicographically smallest destination first
        foreach (var ticket in tickets)
        {
            if (!graph.ContainsKey(ticket[0]))
                graph[ticket[0]] = new PriorityQueue<string, string>();
            graph[ticket[0]].Enqueue(ticket[1], ticket[1]);
        }

        // Step 2: Start Hierholzer's algorithm from "JFK"
        DFS("JFK");

        // Step 3: The itinerary is built in reverse, so convert to list
        return itinerary.ToList();
    }

    // Hierholzer's Algorithm DFS
    private void DFS(string node)
    {
        // While there are unused tickets (edges) from this airport (node)
        while (graph.ContainsKey(node) && graph[node].Count > 0)
        {
            // Always choose the lexicographically smallest next airport
            var next = graph[node].Dequeue();
            // Recursively visit the next airport
            DFS(next);
        }
        // Once all edges from this node are used, add the node to the itinerary
        // This is the "postorder" step of Hierholzer's algorithm
        itinerary.AddFirst(node);
    }
}
