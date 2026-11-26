/*
1. Pattern: Two Pointer Pattern
1.1 Pattern1: Converging
LeetCode 15 – 3Sum
https://leetcode.com/problems/3sum/description/
nums[i] + nums[j] + nums[k] == 0
Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
*/

//Structure
public IList<IList<int>> ThreeSum(int[] nums)
{
    // Initialize result collection
    // Sort the array

    for (int i = 0; i < nums.Length - 2; i++)
    {
        // Skip duplicate i values
        // Initialize left = i + 1
        // Initialize right = nums.Length - 1
        while (left < right)
        {
            // Calculate currentSum = nums[i] + nums[left] + nums[right]
            if (currentSum == 0)
            {
                // Add triplet to result
                // Move both pointers
                // Skip duplicate left values
                // Skip duplicate right values
            }
            else if (currentSum < 0)
            {
                // Move left
            }
            else
            {
                // Move right
            }
        }
    }

    // Return result
}

//-------------------------------------------------------------------------------------------------------------

//Code:

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result =  new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int>
                    {
                        nums[i], nums[left], nums[right]
                    });

                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                        left++;

                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}



