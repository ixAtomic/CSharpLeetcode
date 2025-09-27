using Xunit;
using LeetCode.LeetCodeTop150.Matrix;

namespace LeetcodeTestProject.LeetCodeTop150.Matrix;

public class ValidSudokuTests
{
    [Fact]
    public void IsValidSudoku_ValidBoard_ReturnsTrue()
    {
        var board = new char[][]
        {
            new[] {'5','3','.','.','7','.','.','.','.'},
            new[] {'6','.','.','1','9','5','.','.','.'},
            new[] {'.','9','8','.','.','.','.','6','.'},
            new[] {'8','.','.','.','6','.','.','.','3'},
            new[] {'4','.','.','8','.','3','.','.','1'},
            new[] {'7','.','.','.','2','.','.','.','6'},
            new[] {'.','6','.','.','.','.','2','8','.'},
            new[] {'.','.','.','4','1','9','.','.','5'},
            new[] {'.','.','.','.','8','.','.','7','9'}
        };

        var solution = new ValidSudoku();
        Assert.True(solution.IsValidSudoku(board));
    }
}