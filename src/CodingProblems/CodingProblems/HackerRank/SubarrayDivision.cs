namespace CodingProblems.HackerRank;

public static class SubarrayDivision
{
    public static int Birthday(int[] s, int d, int m)
    {
        // Test inputs 1 1,2,1,3,2
        // Test Day 3,
        // Test month 2
        // Need to create a segment that is the size of the month (2 in this case) that make a total of the day (3)
        // What's the most efficient way possible to do this?
        // Contiguous?
        
        // working code, this could be WAY more efficient
        int response = 0;
        int length = s.Length;
        if (length > 1)
        {
            for (int i = 0; i < length - m + 1; i++)
            {
                int holder = 0;
                if (m > 1)
                {
                    for (int windowSlide = 0; windowSlide < m; windowSlide++)
                    {
                        holder += s[i + windowSlide];
                    }

                    if (holder == d)
                    {
                        response++;
                    }
                }
                else
                {
                    if (s[i] == d)
                    {
                        response++;
                    }
                }
            }
        }
        else
        {
            if (s[0] == d)
            {
                response++;
            }
        }

        return response;
    }
}