namespace CodingProblems.HackerRank;

public static class CatsAndAMouse
{
    private static readonly List<string> CatMouseResponseOptions = new List<string>
    {
        "Cat A",
        "Cat B",
        "Mouse C"
    };
    
    public static string CatAndMouse(int catA, int catB, int mouseC)
    {
        if (catA == mouseC && catB == mouseC) return CatMouseResponseOptions[2];

        var catADistance = 0;
        var catBDistance = 0;
        if (catA >= mouseC)
        {
            catADistance = catA - mouseC;
        }
        else
        {
            catADistance = mouseC - catA;
        }
        
        if (catB >= mouseC)
        {
            catBDistance = catB  - mouseC;
        }
        else
        {
            catBDistance = mouseC - catB;
        }

        if (catADistance == catBDistance)
        {
            return CatMouseResponseOptions[2];
        }

        if (catADistance > catBDistance)
        {
            return CatMouseResponseOptions[1];
        }

        if (catADistance < catBDistance)
        {
            return CatMouseResponseOptions[0];
        }

        throw new Exception("Math not valid");
    }
}