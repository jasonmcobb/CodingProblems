namespace CodingProblems.LeetCode;

public static class LongestCommonPrefix
{
    public static string ComparePrefix(string[] stringArray)
    {
        string outputHolder = "";
        for (int i = 0; i < stringArray[0].Length; i++)
        {
            
            var characterForCompare = stringArray[0].ToCharArray()[i];
            var count = 0;
            foreach (var item in stringArray)
            {
                var charArray = item.ToCharArray();
                if (i < charArray.Length && charArray[i] == characterForCompare)
                {
                    count++;
                }
            }

            if (count == stringArray.Length)
            {
                outputHolder += characterForCompare;
            }
            else
            {
                break;
            }
        }
        return outputHolder;
    }
}