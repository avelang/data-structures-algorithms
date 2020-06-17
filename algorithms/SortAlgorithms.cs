using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    public class SortAlgorithms
    {

        public int[] BubbleSort(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int swaps = 0;
                for (int j = 0; j < n-1-i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        swap(nums, j, j + 1);
                        swaps++;
                    }
                }
                if (swaps == 0)
                    break;
            }
            return nums;
        }

        public int[] swap(int[] array, int i, int j)
        {
            array[i] = array[i] + array[j];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];
            return array;
        }

        public int[] InsertionSort(int[] nums)
        {
            InsertionSortGeneric(nums, 0, 1);
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    int lastSoretdIndex = i-1;
            //    int numToAdd = nums[i];
            //    int indexToAdd = BinaryInsertIndex(nums, 0, lastSoretdIndex, numToAdd);
            //    for (int k = i; k > indexToAdd; k--)
            //    {
            //        nums[k] = nums[k - 1];
            //    }
            //    nums[indexToAdd] = numToAdd;
            //}
            return nums;
        }

        public int BinaryInsertIndex(int[] nums, int begin, int end, int num)
        {
            int mid = (begin + end) / 2;
            if(num<nums[begin])
            {
                return 0;
            }
            else if(num> nums[end])
            {
                return end + 1;
            }
            else if(mid>0 && num > nums[mid-1] && num < nums[mid])
            {
                return mid;
            }
            else if(num > nums[mid] && num < nums[mid+1])
            {
                return mid + 1;
            }
            else if(num < nums[mid-1]) 
            {
                return BinaryInsertIndex(nums, begin, mid - 1, num);
            }
            else //if(num > nums[mid])
            {
                return BinaryInsertIndex(nums, mid + 1, end, num);
            }
        }

        public int[] SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int maxNumIndex = 0;
                int flips = 0;
                for (int j = 0; j < nums.Length-i; j++)
                {
                    if (nums[j] > nums[maxNumIndex])
                    {
                        maxNumIndex = j;
                        flips++;
                    }
                        
                    if(j == nums.Length - i - 1)
                    {
                        if(maxNumIndex!=j)
                        {
                            swap(nums, j, maxNumIndex);
                        }
                    }
                }
                if (flips == nums.Length - i - 1)
                    break;
            }
            return nums;
        }

        public int[] QuickSort(int[] nums)
        {
            Partition(nums, 0, nums.Length - 1);
            return nums;
        }

        public int[] ShellSort(int[] nums)
        {
            int[] increments = { 121, 40, 13, 4, 1 };
            foreach (var increment in increments)
            {
                if(increment<=(nums.Length/2))
                {
                    HSort(nums, increment);
                }
            }
            return nums;
        }

        public void HSort(int[] nums, int increment)
        {
            for (int i = 0; i < increment; i++)
            {
                InsertionSortGeneric(nums, i, increment);
            }
        }

        public void InsertionSortGeneric(int[] nums, int startIndex, int increment)
        {
            for (int i = startIndex + increment; i < nums.Length; i+=increment)
            {
                int lastSortedIndex = i - increment;
                int numToAdd = nums[i];
                AddToSortedList(nums, startIndex, lastSortedIndex, increment, numToAdd);
            }
        }

        public void AddToSortedList(int[] nums, int startIndex, int lastSortedIndex, int increment, int numToAdd)
        {
            int indexToAdd = startIndex;
            for (int i = lastSortedIndex; i >= 0; i-=increment)
            {
                if(numToAdd >= nums[i])
                {
                    indexToAdd = i + increment;
                    break;
                }
            }

            if(nums[indexToAdd]!=numToAdd)
            {
                for (int i = lastSortedIndex + increment; i >= indexToAdd + increment; i -= increment)
                {
                        nums[i] = nums[i - increment];
                }
                nums[indexToAdd] = numToAdd;
            }
        }

        public void Partition(int[] nums, int start ,int end)
        {
            int partitionIndex = -1;
            if (end > start)
            {
                int partitionValue = nums[end];
                int leftIndex = start;
                int rightIndex = end - 1;

                while (rightIndex > leftIndex)
                {
                    if (nums[leftIndex] < partitionValue)
                        leftIndex++;
                    if (nums[rightIndex] > partitionValue)
                        rightIndex--;
                    if (leftIndex < rightIndex && nums[leftIndex] > partitionValue && nums[rightIndex] < partitionValue)
                    {
                        swap(nums, leftIndex, rightIndex);
                        leftIndex++;
                        rightIndex--;
                    }
                }
                if (leftIndex >= rightIndex)
                {
                    partitionIndex = leftIndex;
                    if(nums[partitionIndex] > nums[end]) // 
                    {
                        swap(nums, partitionIndex, end);
                    }
                    else
                    {
                        partitionIndex = end;
                    }
                }
            }

            if (partitionIndex != -1)
            {
                Partition(nums, partitionIndex + 1, end);
                Partition(nums, start, partitionIndex - 1);
            }
        }

        public int[] MergeSort(int[] nums)
        {
            return DivideAndSort(nums, 0, nums.Length - 1);
        }
        public int[] DivideAndSort(int[] nums, int startIndex, int endIndex)
        {
            if(endIndex > startIndex)
            {
                int mid = (startIndex + startIndex) / 2;

                int[] left = DivideAndSort(nums, startIndex, mid);
                int[] right = DivideAndSort(nums, mid + 1, endIndex);

                return Merge(left, right);
            }
            return new int[] { nums[startIndex] };
        }

        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i=0, j = 0;
            int counter = 0;
            int leftEnd = left.Length - 1; 
            int rightEnd = right.Length - 1; 
            while (i <= leftEnd || j <= rightEnd)
            {
                if (i <= leftEnd && j <= rightEnd)
                {
                    if (left[i] < right[j])
                    {
                        result[counter] = left[i];
                        i++;
                    }
                    else if (right[j] < left[i])
                    {
                        result[counter] = right[j];
                        j++;
                    }
                }
                else if (i <= leftEnd && j > rightEnd)
                {
                    result[counter] = left[i];
                    i++;
                }
                else if (i > leftEnd && j <= rightEnd)
                {
                    result[counter] = right[j];
                    j++;
                }
                counter++;
            }
            return result;
        }
    }
}
