namespace CodingProblemsTests.LeetCodeTests;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new []{1,1,2}, 2)]
    [InlineData(new []{0,0,1,1,1,2,2,3,3,4}, 5)]
    public void CalculateScoresReturnsCorrectly(int[] nums, int expectedOutput)
    {
        var response = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);
        
        Assert.Equal(expectedOutput, response);
    }
}