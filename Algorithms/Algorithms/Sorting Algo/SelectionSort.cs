using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting_Algo
{
    internal class SelectionSort : ISorts
    {
        public int[] Sort(int[] nums)
        {
            return SelectionSortImp(nums);
        }
        //find smallest one Index and place

        public int[] SelectionSortImp(int[] nums) 
        {
            //20 4 3 5 10

            int smlIndex;
            int n = nums.Length;
            int temp;
            for (int i = 0; i < n - 1; i++) 
            {
                smlIndex = i;
                for (int j = i + 1; j < n; j++) 
                {
                    if (nums[smlIndex] > nums[j]) 
                    {
                        smlIndex = j;
                    }
                }
                temp = nums[i];
                nums[i] = nums[smlIndex];
                nums[smlIndex] = temp;
            }

            //time: O(n^2)
            //space: O(1)

            return nums;
        }
    }
}
