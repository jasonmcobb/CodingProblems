using System.Collections.Immutable;

namespace CodingProblems.HackerRank;

public class ElectronicsShop
{
    public static int GetMoneySpent(int[] keyboards, int[] drives, int budget)
    {
        Array.Sort(keyboards);
        Array.Reverse(keyboards);
        Array.Sort(drives);

        if ((keyboards.Last() + drives.First() > budget))
        {
            return -1;
        }

        var holder = (from keyboard in keyboards from drive in drives select keyboard + drive)
            .OrderByDescending(value => value)
            .ToList();

        return holder.First(total => total <= budget);
    }
}