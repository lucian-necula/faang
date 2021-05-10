using System;

public partial class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var indexToFind = nums.Length - k;

        return QuickSelect(nums, 0, nums.Length - 1, indexToFind);
    }

    public void Swap(int[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public int GetPartition(int[] nums, int left, int right)
    {
        var i = left;

        for (var j = left; j <= right; j++)
        {
            if (nums[j] <= nums[right])
            {
                Swap(nums, i, j);
                i++;
            }
        }
        return i - 1;
    }

    public int QuickSelect(int[] nums, int left, int right, int indexToFind)
    {
        var partitionIndex = GetPartition(nums, left, right);

        if (partitionIndex == indexToFind)
        {
            return nums[partitionIndex];
        }
        else if (indexToFind < partitionIndex)
        {
            return QuickSelect(nums, left, partitionIndex - 1, indexToFind);
        }
        else
        {
            return QuickSelect(nums, partitionIndex + 1, right, indexToFind);
        }
    }
}