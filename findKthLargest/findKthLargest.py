def swap(array, i, j) :
  temp = array[i]
  array[i] = array[j]
  array[j] = temp


def getPartition(nums, left, right):
  i = left

  for j in range(left, right + 1):
    if  nums[j] <= nums[right] :
      swap(nums, i, j)
      i+=1
  return i - 1


def quickSort(nums, left, right):
  if left < right:
    partitionIndex = getPartition(nums, left, right)

    quickSort(nums, left, partitionIndex - 1)
    quickSort(nums, partitionIndex + 1, right)
  

def findKthLargest(nums, k) :
  indexToFind = len(nums) - k
  quickSort(nums, 0, len(nums) - 1)
  return nums[indexToFind]

array = [5,3,1,6,4,2]
kToFind = 4

print(findKthLargest(array, kToFind))
