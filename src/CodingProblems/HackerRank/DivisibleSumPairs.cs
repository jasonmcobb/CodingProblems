namespace CodingProblems.HackerRank;

public class DivisibleSumPairs
{
    public static int DivisiblePairs(int n, int k, List<int> ar)
    {
        // Problem Statement:
        // https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true
        
        // Notes:
        // need to sum all pairs in order so if my given array is 1,2,3,4,5,6 then I would need to run through 1+2 1+3 1+4.. then 
        // 2+ each
        // also are the sums divisible by K?
        // brute force is nested loop. Lets do this first and refine.
        // n doesn't seem to matter as a useful part of this input as it's the array size. Might as well use it. 
        var output = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    output++;
                }
            }
        }
        
        return output;
    }
}