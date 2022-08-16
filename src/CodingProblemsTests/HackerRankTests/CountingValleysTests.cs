namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class CountingValleysTests
{
    [Theory]
    [InlineData(8, "UDDDUDUU", 1)]
    [InlineData(4, "DUDU", 2)]
    [InlineData(12, "DDUUDDUDUUUD", 2)]
    public void BillDivisionReturnsCorrectly(int steps, string path, int expectedResult)
    {
        var result = CountingValleys.ValleyCount(steps, path);
        Assert.Equal(expectedResult, result);
    }
}