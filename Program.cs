/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.

Example 1:
    Input: nums = [0,1,0,3,12]
    Output: [1,3,12,0,0]

Example 2:
    Input: nums = [0]
    Output: [0]
*/

namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            Console.WriteLine($" Input: [{String.Join(",", nums)}]");
            RearrangeArrays(nums);
            Console.WriteLine($"Output: [{String.Join(",", nums)}]\n");

            nums = new int[] { 0 };
            Console.WriteLine($" Input: [{String.Join(",", nums)}]");
            RearrangeArrays(nums);
            Console.WriteLine($"Output: [{String.Join(",", nums)}]\n");

            nums = new int[] { 4, 3, 2, 0, 0 };
            Console.WriteLine($" Input: [{String.Join(",", nums)}]");
            RearrangeArrays(nums);
            Console.WriteLine($"Output: [{String.Join(",", nums)}]\n");

            nums = new int[] { 0, 0, 0, 2, 5, 1 };
            Console.WriteLine($" Input: [{String.Join(",", nums)}]");
            RearrangeArrays(nums);
            Console.WriteLine($"Output: [{String.Join(",", nums)}]\n");

            nums = new int[] { 5, 1, 7, 4 };
            Console.WriteLine($" Input: [{String.Join(",", nums)}]");
            RearrangeArrays(nums);
            Console.WriteLine($"Output: [{String.Join(",", nums)}]\n");

            nums = new int[] { };
            Console.WriteLine($" Input: [{String.Join(",", nums)}]");
            RearrangeArrays(nums);
            Console.WriteLine($"Output: [{String.Join(",", nums)}]\n");
        }

        static void RearrangeArrays(int[] array)
        {
            // Edge cases
            if (array.Length == 0 || array.Length == 1) return;

            #region Final Attempt
            int lastZeroPosition = 0;
            for (int a = 0; a < array.Length; a++)
            {
                // if position is not zero, put that index in lastZeroPosition
                if (array[a] != 0)
                {
                    if (a != lastZeroPosition)
                    {
                        array[lastZeroPosition] = array[a];
                        array[a] = 0;
                    }
                    lastZeroPosition++;
                }
            } 
            #endregion

            #region Second Attempt
            //int lastZeroPosition = 0;
            //int temp = 0;
            //for (int a = 0; a < array.Length; a++)
            //{
            //    // if position is not zero, put that index in lastZeroPosition
            //    if (array[a] != 0)
            //    {
            //        temp = array[lastZeroPosition];
            //        array[lastZeroPosition] = array[a];
            //        array[a] = temp;
            //        lastZeroPosition++;
            //    }
            //} 
            #endregion

            #region First Attempt
            //for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        if (array[i] == 0)
            //        {
            //            for (int j = i + 1; j < array.Length; j++)
            //            {
            //                if (array[j] != 0)
            //                {
            //                    array[i] = array[j];
            //                    array[j] = 0;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            #endregion
        }
    }
}
