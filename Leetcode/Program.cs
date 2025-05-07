// See https://aka.ms/new-console-template for more information
using LeetCode;

var google = new GoogleSolutions();

//********************  Arrays *********************************

//string[] emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"];

//int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

//int[] seats = [1, 0, 0, 0, 1, 0, 1];

//(int[] quality, int[] wage, int k) workers = ([10, 20, 5], [70, 50, 30], 2);

//******************** End Arrays *********************************


//********************  Linked Lists *********************************

//var x = new ListNode().createList([9, 9, 9, 9, 9, 9, 9]);
//var y = new ListNode().createList([9, 9, 9, 9]);
//var x = new ListNode().createList([2, 4, 3]);
//var y = new ListNode().createList([5, 6, 4]);


//var nodes = google.AddTwoNumbers(x, y);

//while (nodes is not null)
//{
//    Console.WriteLine(nodes.val);
//    nodes = nodes.next;
//}

//******************** End Linked Lists *********************************

//********************  Trees / Graphs *********************************

char[][] grid = [
  ['1','1','1','1','0'],
  ['1','1','0','1','0'],
  ['1','1','0','0','0'],
  ['0','0','0','0','0']
];

Console.WriteLine(google.NumIslands(grid));

//********************  End Trees / Graphs *********************************

