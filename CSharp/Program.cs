using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Algorithms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 100, 23, 36, 14, 5, 69, 7, 8, 9, 1000, 11, 12, 133, 214, 515, 311 };

            nums = Do_Merge_Sort(nums);

            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }

        }

        static List<int> Do_Merge_Sort(List<int> arr)
        {
            List<int> list = SortingAlgorithms.Merge_Sort(arr);

            return list;
        }

        static int[]? Do_Bubble_Sort(int[] arr)
        {
            return null;
        }

        static int[]? Do_Quick_Sort(int[] arr)
        {
            return null;
        }

        static int[]? Do_Selection_Sort(int[] arr)
        {
            return null;
        }

        static int[]? Do_Insertion_Sort(int[] arr)
        {
            return null;
        }
    }
}