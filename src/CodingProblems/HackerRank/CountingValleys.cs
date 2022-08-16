namespace CodingProblems.HackerRank;

public static class CountingValleys
{
    public static int ValleyCount(int steps, string path)
    {
        var charArray = path.ToCharArray();
        
        const char up = 'U';
        const char down = 'D';
        
        var seaLevel = 0;
        var valleyCount = 0;
        
        foreach (var step in charArray)
        {
            switch (step)
            {
                case up:
                    seaLevel += 1;
                    break;
                case down:
                    seaLevel -= 1;
                    break;
            }

            if (seaLevel == -1 && step == down)
            {
                valleyCount += 1;
            } 
        }
        
        return valleyCount;
    }
}