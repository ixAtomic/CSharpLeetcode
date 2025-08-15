using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LeetCode.CapitalOne;

namespace LeetcodeTestProject.CapitalOne;

public class ThreeSumMultiplicityTests
{
    [Fact]
    public void ThreeSumMulti_ReturnsExpected_ForSampleInput()
    {
        var solver = new _3SumMultiplicity();
        int[] arr = { 1, 1, 2, 2, 2, 2 };
        int target = 5;
        int expected = 12;

        int result = solver.ThreeSumMulti(arr, target);

        Assert.Equal(expected, result);
    }
}
