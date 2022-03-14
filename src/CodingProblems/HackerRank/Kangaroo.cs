namespace CodingProblems.HackerRank;

public class Kangaroo
{
    public static string Result(int x1, int v1, int x2, int v2)
    {
        if ((x1 >= x2 && v1 >= v2) || (x1 <= x2 && v1 <= v2))
        {
            return "NO";
        }

        return (x1 - x2) % (v2 - v1) == 0 ? "YES" : "NO";
    }
}