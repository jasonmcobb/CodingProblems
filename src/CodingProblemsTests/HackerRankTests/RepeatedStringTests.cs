namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class RepeatedStringTests
{
    [Theory]
    [InlineData("aba", 10, 7)]
    [InlineData("ceebbcb", 817723, 0)]
    [InlineData("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
    public void CalculateScoresReturnsCorrectly(string subStringToConsider,
        long infiniteStringCharacterCount, 
        long expectedResult)
    {
        Assert.Equal(expectedResult, RepeatedString.RepeatedStringFinder(subStringToConsider, infiniteStringCharacterCount));
    }
}