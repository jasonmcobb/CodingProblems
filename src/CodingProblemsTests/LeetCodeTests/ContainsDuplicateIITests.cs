using System;
using System.IO;

namespace CodingProblemsTests.LeetCodeTests;

public class ContainsDuplicateIITests
{
    [Theory]
    [InlineData(new []{1,2,3,1}, 3, true)]
    [InlineData(new []{1,0,1,1}, 1,true)]
    [InlineData(new []{1,2,3,1,2,3}, 2, false)]
    [InlineData(new []{1,2}, 2, false)]
    public void CalculateScoresReturnsCorrectly(int[] nums, int k, bool expectedResponse)
    {
        var response = ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);
        Assert.Equal(expectedResponse, response);
    }
    
    [Fact]
    public void BigDataTest()
    {
        var expectedResponse = false;
        var k = 612;
        var path = 
            "/Users/jasoncobb/GitHub/CodingProblems/src/CodingProblemsTests/LeetCodeTests/LeetCodeSupplimentalData/ContainsDuplicateIILargeDataSet.txt";
        var bigDataSetString = File.ReadAllLines(path);
        var bigDataSetInt = Array.ConvertAll(bigDataSetString, int.Parse);
        
        var response = ContainsDuplicateII.ContainsNearbyDuplicate(bigDataSetInt, k);
        Assert.Equal(expectedResponse, response);


    }
}
