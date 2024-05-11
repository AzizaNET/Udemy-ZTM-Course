using Algorithms.Sorting_Algo;
using System.Collections.Concurrent;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nums = { 20, 4, 3, 5, 10 };

            var res = SortCilent(new ConcreteCreatorS());
            int[] ns = res.Sort(nums);
            foreach (int i in ns) 
            {
                Console.WriteLine(i);
            }
        }

        public static ISorts SortCilent(SortCreator s) 
        {
            var res = s.Operation();

            return res;
        }
    }
}