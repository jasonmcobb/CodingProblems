namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class DivisibleSumPairsTests
{
    [Theory]
    [InlineData(6,3,new int[]{1,3,2,6,1,2}, 5)] // Default test in problem
    public void DivisibleSumPairsReturnsCorrectResponse(int n, int k, int[] ar, int expectedOutput)
    {
        var result = DivisibleSumPairs.DivisiblePairs(n, k, ar.ToList());
        Assert.Equal(expectedOutput, result);
    }
}