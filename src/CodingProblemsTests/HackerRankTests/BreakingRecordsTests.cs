namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class BreakingRecordsTests
{
    [Theory]
    [InlineData(new []{10, 5, 20, 20, 4, 5, 2, 25, 1},new []{2,4})]
    public void CalculateScoresReturnsCorrectly(int[] inputOne, int[] expectedOutput)
    {
        const int outputLength = 2;
        var response = BreakingRecords.CalculateScore(inputOne);
        Assert.Equal(outputLength, response.Count);
        for (int i = 0; i < outputLength; i++)
        {
            Assert.Equal(expectedOutput[i], response[i]);
        }
    }
}