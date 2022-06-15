namespace CodingProblems.HackerRank;

public static class BillDivision
{
    public static int BonAppetite(List<int> bill, int k, int b)
    {
        // b = amount charged
        // k = 0 besed index of item not eaten
        // list of item prices

        if ((bill.Sum() - bill[k])/2 < b)
        {
            return b - (bill.Sum() - bill[k]) / 2;
        }
        return 0;
    }
}