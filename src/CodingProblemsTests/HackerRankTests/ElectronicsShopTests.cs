namespace CodingProblemsTests.HackerRankTests;

public class ElectronicsShopTests
{
    [Theory]
    [InlineData(new int[]{3, 1}, new int[]{5, 2, 8}, 10, 9)] // Default test in problem
    [InlineData(new int[]{4}, new int[]{5}, 5, -1)] // Default test in problem
    public void ElectronicsShopReturnsCorrectOutput(int[] keyboards, int[] drives, int budget, int expectedOutput)
    {
        var result = ElectronicsShop.GetMoneySpent(keyboards, drives, budget);
        Assert.Equal(expectedOutput, result);
    }
}