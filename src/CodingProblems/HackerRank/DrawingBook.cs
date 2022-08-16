using System.Security.Cryptography.X509Certificates;

namespace CodingProblems.HackerRank;

public static class DrawingBook
{
    public static int PageCount(int pagesInBook, int pageToTurnTo)
    {
        // Can start turning pages from front or back
        var startFromFront = !(pagesInBook / 2 < pageToTurnTo);
        
        // Edge cases
        if (
            pageToTurnTo == 1 || 
            pagesInBook == pageToTurnTo || 
            (
                !startFromFront && 
                (pagesInBook % 2 != 0) && 
                (pagesInBook - pageToTurnTo == 1)
                )
            )
        {
            return 0;
        }

        if (startFromFront)
        {
            var counter = 1;
            for (var i = 2; i <= pageToTurnTo; i += 2)
            {
                if (i == pageToTurnTo || i + 1 == pageToTurnTo)
                {
                    return counter;
                }
                
                counter++;
            }
        }
        else
        {
            var counter = 0;
            for (var i = pagesInBook; i >= pageToTurnTo; i -= 2)
            {
                if (counter == 0 && (pagesInBook % 2 == 0))
                {
                    if (i - 1 == pageToTurnTo)
                    {
                        return 1;
                    }
                }
                else if (i == pageToTurnTo || i - 1 == pageToTurnTo)
                {
                    return counter;
                }

                counter++;
            }
        }

        throw new Exception("Failed to find page");
    }
}