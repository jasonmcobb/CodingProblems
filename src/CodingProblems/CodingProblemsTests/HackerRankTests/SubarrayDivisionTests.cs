using System.Diagnostics.CodeAnalysis;
using CodingProblems.HackerRank;
using Xunit;

namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class SubarrayDivisionTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 3, 2 }, 3, 2, 2)]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2, 0)]
    [InlineData(new int[] { 4 }, 4, 1, 1)]
    [InlineData(
        new int[]
        {
            3, 5, 4, 1, 2, 5, 3, 4, 3, 2, 1, 1, 2, 4, 2, 3, 4, 5, 3, 
            1, 2, 5, 4, 5, 4, 1, 1, 5, 3, 1, 4, 5, 2, 3, 2, 5, 2, 5,
            2, 2, 1, 5, 3, 2, 5, 1, 2, 4, 3, 1, 5, 1, 3, 3, 5
        }, 18, 6, 10)]
    public void SubarrayDivisionReturnsCorrectly(int[] s, int d, int m, int expectedOutput)
    {
        var response = SubarrayDivision.Birthday(s, d, m);
        Assert.Equal(expectedOutput, response);
    }
}