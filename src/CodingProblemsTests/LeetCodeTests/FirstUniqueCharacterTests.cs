namespace CodingProblemsTests.LeetCodeTests;

public class FirstUniqueCharacterTests
{
    [Theory]
    [InlineData("leetcode",0)]
    [InlineData("loveleetcode",2)]
    [InlineData("aabb",-1)]
    public void CalculateScoresReturnsCorrectly(string inputOne,int expectedOutput)
    {
        var response = FirstUniqueCharacter.FirstUniqChar(inputOne);
        Assert.Equal(expectedOutput, response);
    }
}