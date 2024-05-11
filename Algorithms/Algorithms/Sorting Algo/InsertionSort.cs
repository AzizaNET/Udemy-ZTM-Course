using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting_Algo
{
    internal class InsertionSort : ISorts
    {
        public int[] Sort(int[] nums)
        {
            return InsertionSortImp(nums);
        }
        public int[] InsertionSortImp(int[] nums) 
        {
            //20 4 3 5 10
            int num;
            
            for (int i = 1; i < nums.Length; i++) 
            {
                int j = i-1;
                num = nums[i];
                while (j >= 0 && num < nums[j]) 
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j+1] = num;
            }

            return nums;
        }
    }
}
