using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Graph.DepthFirstSearchProblems;
//BACKTRACKING algorithm
//N is the number of nodes
//Time Complexity is O(2^N * N)
//Space Complexity is O(N)
class AllPathsFromSourceToTarget
{
    private int _target;
    private int[][] _graph;
    private List<List<int>> _results;

    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        _target = graph.Length - 1;
        _graph = graph;
        _results = new List<List<int>>();

        var path = new LinkedList<int>();
        path.AddLast(0);
        Backtrack(0, path);

        return (IList<IList<int>>)_results;
    }

    private void Backtrack(int currentNode, LinkedList<int> path)
    {
        if(currentNode == _target)
        {
            _results.Add(path.ToList());
            return;
        }

        foreach(var node in _graph[currentNode])
        {
            path.AddLast(node);
            Backtrack(node, path);
            path.RemoveLast();
        }
    }
}

//INFO
//Backtracking algorithms are widely used for problems where you need to explore all possible solutions and "backtrack" when a partial solution cannot lead to a valid answer.Here are some common use cases:
//1.	Combinatorial Problems
//•	Generating all permutations or combinations of a set(e.g., generating all possible orderings of numbers).
//•	Subset sum and partition problems.
//2.	Constraint Satisfaction Problems
//•	Solving puzzles like Sudoku, N-Queens, or crosswords.
//•	Assigning values to variables under constraints (e.g., coloring a map with minimum colors).
//3.	Path Finding
//•	Finding all paths or a specific path in a graph or maze(as in your code).
//•	Word search in a grid.
//4.	Decision Tree Traversal
//•	Exploring all possible moves in games (e.g., chess, tic-tac-toe).
//•	Generating all valid expressions by inserting operators.
//5.	String Problems
//•	Generating all valid parentheses combinations.
//•	Palindrome partitioning.
//Gotcha:
//Backtracking is powerful but can be slow for large input sizes, so it’s often combined with pruning techniques to skip unnecessary work.
//Let me know if you want an example for any specific use case!

