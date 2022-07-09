namespace CodingProblems.HackerRank;

public class RepeatedString
{
    public static long RepeatedStringFinder(string subStringToConsider, long n)
    {
        const char characterToFind = 'a';
        
        long finalPartialNumber = n % subStringToConsider.Length;
        var repeatedCharacterCount = subStringToConsider.Count(x => x.Equals(characterToFind));
        
        var countOfFullStrings = ((n / subStringToConsider.Length) * repeatedCharacterCount);
        var countOfFinalPartialString = (subStringToConsider[..(int)finalPartialNumber])
            .Count(x => x.Equals(characterToFind));
        
        return countOfFullStrings + countOfFinalPartialString;
    }
}