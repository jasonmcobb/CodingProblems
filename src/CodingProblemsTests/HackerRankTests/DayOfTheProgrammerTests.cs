namespace CodingProblemsTests.HackerRankTests;

public class DayOfTheProgrammerTests
{
    [Theory]
    [InlineData(2017, "13.09.2017")]
    [InlineData(1918, "26.09.1918")]
    [InlineData(2018, "13.09.2018")]
    [InlineData(2020, "12.09.2020")]
    public void DayOfTheProgrammerReturnsCorrectDay(int year, string expectedDate)
    {
        var dayOfTheProgrammer = new DayOfTheProgrammer();
        var response = dayOfTheProgrammer.GetDateFromYear(year);
        Assert.Equal(expectedDate, response);
    }
}