using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting_Algo
{
    internal class BubbleSort : ISorts
    {
        public int[] Sort(int[] nums)
        {
            return BubbleSortImplementation(nums);
        }

        public int[] BubbleSortImplementation(int[] nums) 
        {
            //20 4 3 5 10
            int n = nums.Length;
            int temp;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n-i-1; j++) 
                {
                    if (nums[j] > nums[j + 1]) 
                    {
                        //swap
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            //time: O(n^2)
            //space: O(1)
            return nums;

        }

        
    }
}
