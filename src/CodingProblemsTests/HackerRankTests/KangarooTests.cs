using CodingProblems.HackerRank;
using Xunit;

namespace CodingProblemsTests.HackerRankTests;

public class KangarooTests
{
    [Theory]
    [InlineData(0,3,4,2, "YES")]
    [InlineData(0,2,5,3, "NO")]
    public static void ShouldReturnCorrectResult(int x1, int v1, int y1, int v2, string expectedResult)
    {
        var results = Kangaroo.Result(x1, v1, y1, v2);
        Assert.NotNull(results);
        Assert.NotEmpty(results);
        Assert.Equal(expectedResult, results);
    }
}