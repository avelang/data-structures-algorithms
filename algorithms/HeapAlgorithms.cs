using System;

namespace algorithms
{
    public class HeapAlgorithms
    {
        // given an array A & the index i, 
        // identify the largest among i, left(2i+1) & right(2i+2) & set it to i.
        public int[] MaxHeapify(int[] array, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int len = array.Length;

            // compare i, left
            if (left < len && (array[left] > array[i]))
                largest = left;

            // compare largest, right
            if (right < len && (array[right] > array[largest]))
                largest = right;

            if (largest != i)
            {
                swap(array, i, largest);
                MaxHeapify(array, largest);
            }    
            return array;
        }

        public void swap(int[] array, int i, int j)
        {
            array[i] = array[i] + array[j];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];
        }
    }
}
