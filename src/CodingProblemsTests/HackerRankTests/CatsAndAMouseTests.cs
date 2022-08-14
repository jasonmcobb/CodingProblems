namespace CodingProblemsTests.HackerRankTests;

public class CatsAndAMouseTests
{
    [Theory]
    [InlineData(1, 2, 3, "Cat B")] // Default test in problem
    [InlineData(1, 3, 2, "Mouse C")] // Default test in problem
    public void ElectronicsShopReturnsCorrectOutput(int catA, int catB, int mouseC, string expectedOutput)
    {
        var result = CatsAndAMouse.CatAndMouse(catA, catB, mouseC);
        Assert.Equal(expectedOutput, result);
    }
}