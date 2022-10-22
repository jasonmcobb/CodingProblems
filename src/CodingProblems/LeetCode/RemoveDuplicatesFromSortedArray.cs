namespace CodingProblems.LeetCode;

public static class RemoveDuplicatesFromSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        int i = 0;
        int j = 1;
        
        while (j < nums.Length)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }

            j++;
        }

        return i+1;
    }
}