namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class MigratoryBirdsTests
{
    [Theory]
    [InlineData(new int[]{1,4,4,4,5,3}, 4)]
    [InlineData(new int[]{1,2,3,4,5,4,3,2,1,3,4}, 3)]
    [InlineData(new int[]{1,5,3,4,5,4,5,2,5,3,4}, 5)]
    public void MigratoryBirdsReturnsCorrectResults(int[] arrInput, int expectedResult)
    {
        var response = MigratoryBirds.Result(arrInput.ToList());
        Assert.IsType<int>(response);
        Assert.Equal(expectedResult, response);
    }
}