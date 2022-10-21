namespace CodingProblemsTests.LeetCodeTests;

public class ExistingParenthesesTests
{
    [Theory]
    [InlineData("()",true)]
    [InlineData("()[]{}",true)]
    [InlineData("(]",false)]
    [InlineData("(",false)]
    [InlineData("([])",true)]
    [InlineData("([)",false)]
    public void CalculateScoresReturnsCorrectly(string inputOne,bool expectedOutput)
    {
        var response = ExistingParentheses.Solution(inputOne);
        
        if (expectedOutput)
        {
            Assert.True(response);
        }
        else
        {
            Assert.False(response);
        }
    }
}