namespace CodingProblems.HackerRank;

public class MigratoryBirds
{
    // This is to handle the Migratory Birds problem from Hacker Rank:
    // https://www.hackerrank.com/challenges/migratory-birds/problem?isFullScreen=true

    public static int Result(List<int> arr)
    {
        var results = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 }
        };

        foreach (var item in arr)
        {
            results[item]++;
        }

        var outputHolder = 1;
        
        for (var i = 1; i < 5; i++)
        {
            if ((results[i] >= results[i + 1]) && (results[outputHolder] < results[i]))
            {
                outputHolder = i;
            }
            else if((results[i] < results[i + 1]) && (results[outputHolder] < results[i+1]))
            {
                outputHolder = i + 1;
            }
        }

        return outputHolder;
    }
}