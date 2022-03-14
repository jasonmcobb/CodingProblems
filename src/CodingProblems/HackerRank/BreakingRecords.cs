namespace CodingProblems.HackerRank;

public class BreakingRecords
{
    public static List<int> CalculateScore(int[] scores)
    {
        var highestScoreBrokenCount = 0;
        var lowestScoreBrokenCount = 0;
        var highScoreHolder = scores.First();
        var lowScoreHolder = scores.First();

        for (var i = 1; i < scores.Length; i++)
        {
            if (scores[i] > highScoreHolder)
            {
                highScoreHolder = scores[i];
                highestScoreBrokenCount++;
            }

            if (scores[i] < lowScoreHolder)
            {
                lowScoreHolder = scores[i];
                lowestScoreBrokenCount++;
            }
        }

        return new List<int>{highestScoreBrokenCount,lowestScoreBrokenCount};
    }
}