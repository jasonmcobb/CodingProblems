namespace CodingProblemsTests.LeetCodeTests;

[ExcludeFromCodeCoverage]
public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new []{"flower","flow","flight"},"fl")]
    [InlineData(new []{"dog","racecar","car"},"")]
    [InlineData(new []{"cir","car"},"c")]
    public void CalculateScoresReturnsCorrectly(string[] inputOne, string expectedOutput)
    {
        var response = LongestCommonPrefix.ComparePrefix(inputOne);
        Assert.Equal(expectedOutput, response);
    }
}