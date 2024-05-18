using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting_Algo
{
    internal class MergeSort : ISorts
    {
        //Time Complexity: O(n Log n)
        //Space Complexity: O(n)
        public int[] Sort(int[] nums)
        {
            return MergeSortImp(nums);
        }

        private int[] MergeSortImp(int[] nums)
        {
            //technique Devide and Concure
            //base case: array length is 1
            if(nums.Length <= 1) return nums;

            //split array to left and right sides
            int mid = nums.Length/2;

            int[] left = new int[mid];
            int[] right = new int[nums.Length - mid];

            Array.Copy(nums, 0, left, 0, mid);
            Array.Copy(nums, mid, right, 0, nums.Length-mid);

            return Merge(MergeSortImp(left), MergeSortImp(right));
        }
        private int[] Merge(int[] left, int[] right) 
        {
            //compare two sides
            int[] res = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;
            //merge the two sorted arrays
            while (i< left.Length && j < right.Length) 
            {
                if (left[i] <= right[j])
                {
                    res[k++] = left[i++];
                }
                else 
                {
                    res[k++] = right[j++];
                }
            }
            // copy remaining elements from left, if any
            while (i < left.Length)
            {
                res[k++] = left[i++];
            }

            // copy remaining elements from right, if any
            while (j < right.Length)
            {
                res[k++] = right[j++];
            }

            return res;
        }
    }
}
