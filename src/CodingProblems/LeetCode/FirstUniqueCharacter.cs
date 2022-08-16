namespace CodingProblems.LeetCode;

public static class FirstUniqueCharacter
{
    public static int FirstUniqChar(string s)
    {
        // need to return first unique character location in the string 0 index or -1 if there are no unique characters
        var chars = s.AsSpan();
        var iterationCount = chars.Length;
        var countHolder = new Dictionary<char, int>();
        
        for (var i = 0; i < iterationCount; i++)
        {
            countHolder[chars[i]] = (countHolder.ContainsKey(chars[i]) ? chars[i] : 0) + 1;
        }

        for (var i = 0; i < iterationCount; i++)
        {
            if (countHolder[chars[i]] == 1)
            {
                return i;
            }
        }
        
        return -1;
    }
}