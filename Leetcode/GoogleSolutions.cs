using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode;

public class GoogleSolutions
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> reducedEmails = new HashSet<string>();
        foreach(var email in emails)
        {
            var split = email.Split('@');
            var local = split[0];
            var domain = split[1];

            var separatePlus = local.Split('+');
            var reducedLocal = separatePlus[0];

            reducedLocal = reducedLocal.Replace(".", "");

            var reducedEmail = $"{reducedLocal}@{domain}";

            if (reducedEmails.Contains(reducedEmail))
            {
                continue;
            }

            reducedEmails.Add(reducedEmail);
        }

        return reducedEmails.Count();
    }

    //get maximum value and always get closer by removing the lower number from the list
    //Difficulty: Med
    public int ContainerWithMostWater(int[] height)
    {
        int maxNumber = 0;
        int i = 0;
        int j = height.Length - 1;
        while (i < j)
        {
            int distance = j - i;
            int compareValue;
            if (height[i] > height[j])
            {
                compareValue = height[j];
                j--;
            }
            else
            {
                compareValue = height[i];
                i++;
            }

            var result = compareValue * distance;

            if(maxNumber < result)
            {
                maxNumber = result;
            }
        }

        return maxNumber;
    }

    //sliding window move to the end and track the biggest gap streak
    //Difficulty: Medium
    public int MaxDistToClosestPerson(int[] seats)
    {
        int maxDistance = 0;
        int currentDistance = 0;
        int i = 0;
        while (i < seats.Length)
        {
            if (seats[i] == 1)
            {
                if ((i - currentDistance) == 0 && i != 0)
                {
                    maxDistance = maxDistance > currentDistance ? maxDistance : currentDistance;
                }
                else
                {
                    var calc = (currentDistance + 1) / 2;
                    maxDistance = maxDistance > calc ? maxDistance : calc;
                }

                currentDistance = 0;
            }
            else
            {
                currentDistance++;
            }

            i++;
        }

        return maxDistance > currentDistance ? maxDistance : currentDistance;
    }

    //runner pattern
    //unable to complete
    //Difficulty: Hard
    //probably need to look up heap and priority queue's
    public double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        var minTotal = int.MaxValue;


        throw new NotImplementedException();
    }

    //Difficulty: Med
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? First = l1;
        ListNode? Second = l2;
        ListNode Head = new ListNode();
        ListNode? Result = null;

        var carryOver = 0;

        while (First is not null || Second is not null || carryOver != 0)
        {
            if(Result is null)
            {
                Result = Head;
            }
            else
            {
                Result.next = new ListNode();
                Result = Result.next;
            }

            var total = (First?.val ?? 0) + (Second?.val ?? 0) + carryOver;

            carryOver = total / 10;

            var result = total % 10;

            Result.val = result;

            First = First?.next;
            Second = Second?.next;
        }

        return Head;
    }


    //Real solutions is to look for all the 1's in order and then search for connected 1's and set all to 0,
    //each time you find a 1 it is a root and needs to be searched for more 1's, which will all be set to 0
    //return a count of the number of root nodes you found
    private readonly List<Point> _Offsets = new List<Point>
    {
       new Point(1, 0),
       new Point(0, 1),
       new Point(0, -1),
       new Point(-1, 0),
    };

    public int NumIslands(char[][] grid)
    {
        // BFS prioritizes 1's and processes connected components
        int count = 0;

        foreach(var y in grid.Select((value, index) => new { value, index }))
        {
            foreach(var x in y.value.Select((value, index) => new { value, index }))
            {
                if(x.value == '1')
                {
                    count++;
                    grid[y.index][x.index] = '0';
                    grid = BreadthFirstSearch(x.index, y.index, grid);
                }
            }
        }

        return count;
    }

    private char[][] BreadthFirstSearch(int x, int y, char[][] grid)
    {
        Queue<Point> nodes = new Queue<Point>();
        var visited = new Dictionary<Point, bool>();
        var startPoint = new Point(x, y);
        nodes.Enqueue(startPoint);
        
        while(nodes.Count > 0)
        {
            var current = nodes.Dequeue();

            foreach(var offset in _Offsets)
            {
                Point neighbor = new(current.x + offset.x, current.y + offset.y);

                if (neighbor.x < 0 || neighbor.y < 0 || neighbor.y >= grid.Length || neighbor.x >= grid[neighbor.y].Length)
                {
                    continue;
                }

                if (grid[neighbor.y][neighbor.x] == '1')
                {
                    grid[neighbor.y][neighbor.x] = '0';
                    nodes.Enqueue(neighbor);
                }
            }
        }

        return grid;
    }

    record Point(int x, int y);

    //get the largest x and the largest y and make a 2d grid of points
    //iterate over list and find stones
    //once a stone is found dfs for connected stones
    //count each stone removal
    public int RemoveStones(int[][] stones)
    {
        var lastIndex = stones.Length - 1;

        int x = stones.Max(s => s[0]);
        int y = stones.Max(s => s[1]);
        int max = y;

        if(x > y)
        {
            max = x;
        }

        var EndPoint = new Point(max, max);

        char[,] matrix = new char[max + 1, max + 1];

        foreach(var stone in stones)
        {
            matrix[stone[0], stone[1]] = 'S';
        }

        var count = 0;
        
        for(var i = 0; i < max + 1; i++)
        {
            for(var j = 0; j < max + 1; j++)
            {
                if (matrix[j, i] == 'S')
                {
                    Point startPoint = new(j, i);
                    matrix[j, i] = '\0';
                    (matrix, count) = BFSStones(startPoint, EndPoint, matrix, count);
                }
            }
        }
        
        return count;
    }

    private (char[,] matrix, int count) BFSStones(Point startPoint, Point endPoint, char[,] matrix, int count)
    {
        Queue<Point> nodes = new Queue<Point>();
        nodes.Enqueue(startPoint);

        while(nodes.Count > 0)
        {
            var current = nodes.Dequeue();

            //x direction check
            for(int x = 0; x < endPoint.x + 1; x++)
            {
                var child = matrix[x, current.y];
                if(child == 'S')
                {
                    count++;
                    matrix[x, current.y] = '\0';
                    nodes.Enqueue(new(x, current.y));
                }
            }

            for(int y = 0; y < endPoint.y + 1; y++)
            {
                var child = matrix[current.x, y];
                if (child == 'S')
                {
                    count++;
                    matrix[current.x, y] = '\0';
                    nodes.Enqueue(new(current.x, y));
                }
            }
        }

        return (matrix, count);
    }

    private readonly List<Vector2> _VecOffsets = new List<Vector2>()
    { 
        new(1,0),
        new(0,1),
        new(0,-1),
        new(-1,0)
    };

    public void CleanRoom(Robot robot)
    {
        HashSet<Vector2> visited = new HashSet<Vector2>();
        Dictionary<Vector2, List<Vector2>> adjacencyList = new Dictionary<Vector2, List<Vector2>>();
        var startingPoint = new Vector2(0, 0);
        var direction = new Vector2(1, 0);
        var nodes = new Stack<Vector2>();
        nodes.Push(startingPoint);

        while(nodes.Count > 0)
        {
            var current = nodes.Pop();

            visited.Add(current);

            var forward = current + direction;
            var right = current + new Vector2(direction.Y, -direction.X);
            var left = current + new Vector2(-direction.X, -direction.Y);
            var reverse = current + new Vector2(-direction.Y, direction.X);

            adjacencyList[current] = new List<Vector2>()
            {
                forward,
                right,
                reverse,
                left,
            };
            robot.Clean();

            foreach(var neighbor in adjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    nodes.Push(neighbor);
                    continue;
                }
            }

            var moved = false;
            foreach(var neighbor in adjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    if (robot.Move())
                    {
                        moved = true;
                        break;
                    }
                    var node = nodes.Pop();
                    visited.Add(node);
                }
                robot.TurnRight();
            }
            
            if(nodes.Count > 0 && !moved)
            {
                robot.TurnRight(); //center the robot
                var path = FindShortestPath(current, nodes.Peek(), adjacencyList);
                var vaccumLocation = current;
                foreach(var vec in path)
                {
                    if(current == vec)
                    {
                        continue;
                    }

                    foreach(var neighbor in adjacencyList[vaccumLocation])
                    {
                        if(neighbor == vec)
                        {
                            robot.Move();
                            break;
                        }

                        robot.TurnRight();
                    }
                }
            }
        }

        return;
    }

    private List<Vector2> FindShortestPath(Vector2 start, Vector2 End, Dictionary<Vector2, List<Vector2>> adjacencyList)
    {
        var visited = new HashSet<Vector2>();
        var nodes = new PriorityQueue<Vector2, int>();
        Dictionary<Vector2, Vector2?> Previous = new Dictionary<Vector2, Vector2?>();
        Dictionary<Vector2, int> CurrentShortestPath = new Dictionary<Vector2, int>();

        Previous[start] = null;
        CurrentShortestPath[start] = 0;
        nodes.Enqueue(start, 0);
        visited.Add(start);

        while(nodes.Count > 0)
        {
            var current = nodes.Dequeue();

            foreach(var neighbor in adjacencyList[current])
            {
                var total = CurrentShortestPath[current] + 1;

                if (!visited.Contains(neighbor))
                {
                    nodes.Enqueue(neighbor, total);
                    visited.Add(neighbor);
                }

                if (!CurrentShortestPath.ContainsKey(neighbor))
                {
                    CurrentShortestPath[neighbor] = total;
                    Previous[neighbor] = current;
                    continue;
                }

                if (CurrentShortestPath[neighbor] > total)
                {
                    CurrentShortestPath[neighbor] = total;
                    Previous[neighbor] = current;
                    continue;
                }
            }
        }

        return PathToNode(End, Previous);
    }

    private List<Vector2> PathToNode(Vector2 EndNode, Dictionary<Vector2, Vector2?> Previous)
    {
        Stack<Vector2> path = new Stack<Vector2>();
        var previousNode = Previous[EndNode];
        path.Push(EndNode);

        while (previousNode is not null)
        {
            path.Push((Vector2)previousNode);
            previousNode = Previous[(Vector2)previousNode];
        }

        return path.ToList();
    }

    //current implementation makes it hard to go over a node we have already visited. need to backtrack somehow
    private HashSet<Vector2> CleanRoomRecursive(Vector2 node, Vector2 direction, HashSet<Vector2> visited, Robot robot)
    {
        if (!visited.Contains(node))
        {
            visited.Add(node);
            robot.Clean();
        }

        Vector2 next = node + direction;

        if (!visited.Contains(next))
        {
            if (robot.Move())
            {
                visited = CleanRoomRecursive(next, direction, visited, robot);
            }
        }

        var newDirection = new Vector2(direction.Y, -direction.X);
        next = node + newDirection;
        var checkedRight = false;

        if (!visited.Contains(next))
        {
            checkedRight = true;
            robot.TurnRight();
            if (robot.Move())
            {
                visited = CleanRoomRecursive(next, newDirection, visited, robot);
            }
        }

        newDirection = new Vector2(-direction.X, -direction.Y);
        next = node + newDirection;
        if (!visited.Contains(next))
        {
            if (checkedRight)
            {
                robot.TurnLeft();
            }
            
            robot.TurnLeft();
            if (robot.Move())
            {
                visited = CleanRoomRecursive(next, newDirection, visited, robot);
            }
        }

        //go backwards
        //might need to update this logic to backtrack better. cant just "turn left" if all nodes have been visited from a spot.. need to know how to find unvisited nodes
        robot.TurnLeft();
        var backwards = new Vector2(-direction.Y, direction.X);
        var previous = node + backwards;
        robot.Move(); //shouldnt fail ever
        visited = CleanRoomRecursive(previous, backwards, visited, robot);
        return visited;
    }
}


public interface Robot
{
    // Returns true if the cell in front is open and robot moves into the cell.
    // Returns false if the cell in front is blocked and robot stays in the current cell.
    public bool Move();

    // Robot will stay in the same cell after calling turnLeft/turnRight.
    // Each turn will be 90 degrees.
    public void TurnLeft();
    public void TurnRight();

    // Clean the current cell.
    public void Clean();
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public ListNode createList(List<int> values)
    {
        var Head = new ListNode();
        ListNode? Current = null;
        foreach(var value in values)
        {
            if (Current is null)
            {
                Current = Head;
            }
            else
            {
                Current.next = new ListNode();
                Current = Current.next;
            }

            Current.val = value;
        }

        return Head;
    }
}

