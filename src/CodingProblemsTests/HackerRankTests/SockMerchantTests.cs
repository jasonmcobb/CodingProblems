namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class SockMerchantTests
{
    [Theory]
    [InlineData(new int[]{10,20,20,10,10,30,50,10,20}, 3)]
    public void SockMerchantReturnsCorrectResults(int[] arrInput, int expectedResult)
    {
        var response = SockMerchant.SockMerchantProcessing(arrInput.ToList());
        Assert.IsType<int>(response);
        Assert.Equal(expectedResult, response);
    }
}