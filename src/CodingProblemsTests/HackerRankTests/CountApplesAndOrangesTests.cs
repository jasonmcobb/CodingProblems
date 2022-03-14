using System.Linq;
using CodingProblems.HackerRank;
using Xunit;

namespace CodingProblemsTests.HackerRankTests;

public class CountApplesAndOrangesTests
{
    [Theory]
    [InlineData(1,1,2, 3, 1, 5, new[] {2}, new[]{-2})]
    [InlineData(4,0,5,8,1,10, new[] {4,5,4,7,8,9}, new[]{4,5,4,7,8,9, -1})]
    [InlineData(1,1,7,11,5,15, new[] {-2, 2, 1}, new[]{5, -6})]
    public void CorrectOutputForApplesAndOranges(int expectedApples, int expectedOranges, int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        var response = CountApplesAndOranges.CountApplesAndOrangesInRange(s, t, a, b, apples.ToList(), oranges.ToList());
        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Equal(2, response.Length);
        Assert.Equal(expectedApples, response[0]);
        Assert.Equal(expectedOranges, response[1]);
    }
}