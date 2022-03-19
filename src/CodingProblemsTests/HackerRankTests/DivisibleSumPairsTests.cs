using System.Linq;
using CodingProblems.HackerRank;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;
using Xunit.Abstractions;

namespace CodingProblemsTests.HackerRankTests;

public class DivisibleSumPairsTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public DivisibleSumPairsTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Theory]
    [InlineData(6,3,new int[]{1,3,2,6,1,2}, 5)] // Default test in problem
    public void DivisibleSumPairsReturnsCorrectResponse(int n, int k, int[] ar, int expectedOutput)
    {
        var result = DivisibleSumPairs.DivisiblePairs(n, k, ar.ToList());
        _testOutputHelper.WriteLine($"Processing {result}");
        Assert.Equal(expectedOutput, result);
    }
}