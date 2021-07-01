using System;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
          {
            int[] nums = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Original elements in array:");
            Array.ForEach(nums, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): "+ test(nums,nums));
            int[] nums1 = {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("\nOriginal array elements:");
            Array.ForEach(nums1, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums,nums1));
            int[] nums2 = { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };
            Console.WriteLine("\nOriginal array elements:");
            Array.ForEach(nums2, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums,nums2));
            int[] nums3 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Console.WriteLine("\nOriginal array elements:");
            Array.ForEach(nums3, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums,nums3));

        }

        public static int test(int[] arr,int[] arr2)
        {
            return arr.Sum() - arr2.Sum();
        }

    }

