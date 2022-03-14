namespace CodingProblems.HackerRank;

public class CountApplesAndOranges
{
    public static int[] CountApplesAndOrangesInRange(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        /*
        // Need to return the count from list 1 and list 2 that falls in range of s,t if added to a or subtracted from b
        Oranges only Fall from B and apples A
        */
        var houseRange = Enumerable.Range(s, t - s + 1).ToArray();
        var applesOnHouse = apples.Count(apple => apple + a >= s && (apple + a) <= t);
        var orangesOnHouse = oranges.Count(orange => orange + b >= s && (orange + b) <= t);
        // var applesOnHouse = apples.Count(apple => houseRange.Contains(a + apple));
        // var orangesOnHouse = oranges.Count(orange => houseRange.Contains(b + orange));

        Console.WriteLine(applesOnHouse);
        Console.WriteLine(orangesOnHouse);

        return new[] { applesOnHouse, orangesOnHouse };
    }
}