using System.Diagnostics;

namespace CodingProblems.LeetCode;

public static class ExistingParentheses
{
    public static bool Solution(string s)
    {
        var charSpan = s.AsSpan();
        var charSpanLength = charSpan.Length;
        var charHolder = new List<char>();
        var closingBracketsSpan = ")}]".AsSpan();
        
        if ((charSpanLength % 2) != 0)
        {
            return false;
        }

        for (var i = 0; i < charSpanLength; i++)
        {
            if (closingBracketsSpan.Contains(charSpan[i]))
            {
                if (charHolder.Count > 0)
                {
                    switch (charSpan[i])
                    {
                        case ')':
                            if (charHolder[^1] != '(')
                            {
                                return false;
                            }

                            charHolder.RemoveAt(charHolder.Count - 1);
                            break;
                        case '}':
                            if (charHolder[^1] != '{')
                            {
                                return false;
                            }

                            charHolder.RemoveAt(charHolder.Count - 1);
                            break;
                        case ']':
                            if (charHolder[^1] != '[')
                            {
                                return false;
                            }

                            charHolder.RemoveAt(charHolder.Count - 1);
                            break;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                charHolder.Add(charSpan[i]);
            }
        }

        return charHolder.Count == 0;
    }
}