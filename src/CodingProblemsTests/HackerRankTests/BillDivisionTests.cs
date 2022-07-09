using System.Collections.Generic;
using CodingProblems.HackerRank;

namespace CodingProblemsTests.HackerRankTests;

public class BillDivisionTests
{
   [Theory]
   [InlineData( new []{3, 10, 2, 9}, 1, 12, 5)]
   [InlineData( new []{3, 10, 2, 9}, 1, 7, 0)]
   public void BillDivisionReturnsCorrectly(int[] bill, int k, int b, int expectedResponse)
   {
      var response = BillDivision.BonAppetite(bill.ToList(), k, b);
      Assert.Equal(expectedResponse, response);
   }
}