namespace CodingProblems.HackerRank;

public static class SockMerchant
{
    public static int SockMerchantProcessing(List<int> ar)
    {
        // need to count number of pairs of numbers there are and drop odd leftovers
        var pairs = 0;
        var totalPairs = 0;
        var distinctItems = ar.Distinct().ToArray();
        Console.WriteLine(distinctItems.ToString());
        foreach (var item in distinctItems)
        {
            pairs = ar.Count(x => x.Equals(item));
            
            if (pairs % 2 != 0)
            {
                pairs -= 1;
            }

            totalPairs += pairs / 2;
        }
        return totalPairs;
    }
}