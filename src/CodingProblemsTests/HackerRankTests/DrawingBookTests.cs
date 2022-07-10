namespace CodingProblemsTests.HackerRankTests;

[ExcludeFromCodeCoverage]
public class DrawingBookTests
{
    [Theory]
    [InlineData(6,2,1)]
    [InlineData(6,5,1)]
    [InlineData(5,4,0)]
    [InlineData(101,100,0)]
    [InlineData(101,1,0)]
    [InlineData(101,15,7)]
    [InlineData(101,75,13)]
    public void BillDivisionReturnsCorrectly(int pagesInBook, int pageToTurnTo, int expectedOutput)
    {
        var result = DrawingBook.PageCount(pagesInBook, pageToTurnTo);
        Assert.Equal(expectedOutput, result);
    }
}

// var intsts = new int[]
// {
//     101100,
//     9998,
//     9796,
//     9594,
//     9392,
//     9190,
//     8988,
//     8786,
//     8584,
//     8382,
//     8180,
//     7978,
//     7776,
//     7574
// };