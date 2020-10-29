/*
 * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
 * For example, the square matrix
 * 
 * is shown below:
 * 1 2 3
 * 4 5 6
 * 9 8 9  
 * 
 * The left-to-right diagonal = 1+5+9=15. The right to left diagonal = 3+5+9=17. Their absolute 
 * difference is |15-17|=2.
 * 
 * Function description
 * Complete the function in the editor below.
 * diagonalDifference takes the following parameter:
 * int arr[n][m]: an array of integers
 * 
 * Return
 * int: the absolute diagonal difference
 * 
 * Input Format
 * The first line contains a single integer, n, the number of rows and columns in the square 
 * matrix arr.  Each of the next n lines describes a row, arr[i], and consists of n 
 * space-separated integers arr[i][j].
 * 
 * Constraints
 * -100<=arr[i][j]<=100
 * 
 * Output Format
 * Return the absolute difference between the sums of the matrix's two diagonals as a single integer.
 * 
 * Sample Input
 * 3
 * 11 2 4
 * 4 5 6
 * 10 8 -12
 * 
 * Sample Output
 * 15
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Diagonal_Difference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr[0].Count;
            int resDiag1 = 0;
            int resDiag2 = 0;

            for (int i=0; i < n; i++)
            {
                resDiag1 += arr[i][i];
                resDiag2 += arr[n-1-i][i];
            }

            return Math.Abs(resDiag1 - resDiag2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
