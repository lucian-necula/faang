using System;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length < 1) return new int[] { -1, -1 };
        int firstPos = BinarySearch(nums, 0, nums.Length - 1, target);

        if (firstPos == -1) return new int[] { -1, -1 };

        int endPos = firstPos;
        int startPos = firstPos;
        int temp1 = -1, temp2 = -1;

        while (startPos != -1)
        {
            temp1 = startPos;
            startPos = BinarySearch(nums, 0, startPos - 1, target);
        }
        startPos = temp1;

        while (endPos != -1)
        {
            temp2 = endPos;
            endPos = BinarySearch(nums, endPos + 1, nums.Length - 1, target);
        }
        endPos = temp2;

        return new int[] { startPos, endPos };
    }

    public int BinarySearch(int[] nums, int left, int right, int target)
    {
        int mid = -1, foundVal = -1;
        while (left <= right)
        {
            mid = (int)Math.Floor((double)((left + right) / 2));
            foundVal = nums[mid];
            if (foundVal == target)
            {
                return mid;
            }
            else if (foundVal < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}

