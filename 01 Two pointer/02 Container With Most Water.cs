/*
1. Pattern: Two Pointer Pattern
1.1 Pattern1: Converging
https://leetcode.com/problems/container-with-most-water/description/
11. Container With Most Water
*/

//Structure
public int MaxArea(int[] height)
{
    // Initialize left and right pointers
    // Initialize maxArea = 0

    while (left < right)
    {
        // Calculate width
        // Find minimum height between left and right
        // Calculate currentArea = width * minHeight
        // Update maxArea if currentArea is greater

        if (height[left] < height[right])
        {
            // Move left pointer
        }
        else
        {
            // Move right pointer
        }
    }

    // Return maxArea
}

------------------------------------------------------------------------------

//Code:

public int MaxArea(int[] height)
{
    int left = 0;
    int right = height.Length - 1;

    int maxArea = 0;

    while (left < right)
    {
        int width = right - left;

        int minHeight = Math.Min(
            height[left], height[right]);

        int currentArea = width * minHeight;

        maxArea = Math.Max(maxArea, currentArea);

        // Move the shorter line
        if (height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return maxArea;
}


