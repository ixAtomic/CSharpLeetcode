using LeetCode.LeetCodeTop150;
using Xunit;


namespace LeetcodeTestProject.LeetCodeTop150Tests;
public class GasStationTests
{
    [Fact]
    public void CanCompleteCircuit_Input_1_2_3_4_5_Cost_3_4_5_1_2_Returns_3()
    {
        // Arrange
        var solution = new GasStation();
        int[] gas = { 1, 2, 3, 4, 5 };
        int[] cost = { 3, 4, 5, 1, 2 };

        // Act
        int result = solution.CanCompleteCircuit(gas, cost);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void CanCompleteCircuit_Input_2_3_4_Cost_3_4_3_Returns_Minus1()
    {
        // Arrange
        var solution = new GasStation();
        int[] gas = { 2, 3, 4 };
        int[] cost = { 3, 4, 3 };

        // Act
        int result = solution.CanCompleteCircuit(gas, cost);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void CanCompleteCircuit_Input_5_1_2_3_4_Cost_4_4_1_5_1_Returns_4()
    {
        // Arrange
        var solution = new GasStation();
        int[] gas = { 5, 1, 2, 3, 4 };
        int[] cost = { 4, 4, 1, 5, 1 };

        // Act
        int result = solution.CanCompleteCircuit(gas, cost);

        // Assert
        Assert.Equal(4, result);
    }
}