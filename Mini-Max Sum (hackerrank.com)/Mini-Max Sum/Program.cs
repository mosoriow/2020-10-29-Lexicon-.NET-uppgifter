/*
 * Given five positive integers, find the minimum and maximum values that can be calculated by 
 * summing exactly four of the five integers. Then print the respective minimum and maximum 
 * values as a single line of two space-separated long integers.
 * 
 * Example
 * arr=[1,3,5,7,9]
 * 
 * The minimum sum is 1+3+5+7=16 and the maximum sum is 3+5+7+9=24. The function prints
 * 16 24
 * 
 * Function Description
 * 
 * Complete the miniMaxSum function in the editor below.
 * miniMaxSum has the following parameter(s):
 * arr: an array of 5 integers
 * 
 * Print
 * Print two space-separated integers on one line: the minimum sum and the maximum sum 4 of 5 
 * elements.
 * 
 * Input Format
 * A single line of five space-separated integers.
 * 
 * Constraints
 * 1<=arr[i]<=10^9
 * 
 * Output Format
 * Print two space-separated long integers denoting the respective minimum and maximum values 
 * that can be calculated by summing exactly four of the five integers. (The output can be 
 * greater than a 32 bit integer.)
 * 
 * Sample Input
 * 1 2 3 4 5
 * 
 * Sample Output
 * 10 14
 * 
 * Hints: Beware of integer overflow! Use 64-bit Integer.
 */

using System;

namespace Mini_Max_Sum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            int min = 0;
            int max = 0;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                min += arr[i];
                max += arr[i];
            }

            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for(int j=0;j<arr.Length;j++)
                {
                    if (i != j)
                        sum += arr[j];
                }
                if (min > sum) min = sum;
                if (max < sum) max = sum;
            }
            Console.WriteLine("{0} {1}", min, max);
        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
