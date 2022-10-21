namespace CodingProblems.LeetCode;

public static class ContainsDuplicateII
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var holderDictionary = new Dictionary<int,int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if(holderDictionary.ContainsKey(nums[i]))
            {
                if(((holderDictionary[nums[i]] - i) * -1) <= k)
                    return true;
            }
            holderDictionary[nums[i]] = i;
        }
        
        return false;
    }
}