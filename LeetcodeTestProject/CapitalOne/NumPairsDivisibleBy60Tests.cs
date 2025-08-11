using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.CapitalOne;

namespace LeetcodeTestProject.CapitalOne;

public class NumPairsDivisibleBy60Tests
{
    [Fact]
    public void Test_NumPairsDivisibleBy60_Input1()
    {
        // Arrange
        int[] time = new int[] { 30, 20, 150, 100, 40 };
        int expected = 3;
        var pairs = new PairsOfSongsDivisibleBy60();

        // Act
        int actual = pairs.NumPairsDivisibleBy60(time);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_NumPairsDivisibleBy60_Input2()
    {
        // Arrange
        int[] time = new int[] { 60, 60, 60 };
        int expected = 3;
        var pairs = new PairsOfSongsDivisibleBy60();

        // Act
        int actual = pairs.NumPairsDivisibleBy60(time);

        // Assert
        Assert.Equal(expected, actual);
    }
}
