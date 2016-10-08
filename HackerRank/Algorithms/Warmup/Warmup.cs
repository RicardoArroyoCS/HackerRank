using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using HackerRank.Algorithms;

namespace HackerRank.Algorithms.Warmup
{
    public sealed class Warmup: AlgorithmCategory
    {
        private const string _section = "Warmup";
        private static readonly Warmup _instance = new Warmup();

        public static Warmup Instance
        {
            get
            {
                return _instance;
            }
        }

        #region AVeryBigSum
        [Problem(_category, _section, "AVeryBigSum")]
        public void AVeryBigSumMain()
        {
            int[] arr = new int[]
            {
                1000000001,
                1000000002,
                1000000003, 
                1000000004,
                1000000005,
            };

            AVeryBigSumMain(arr);
        }

        private void AVeryBigSumMain(int[] arr)
        {
            long sum = 0;

            foreach(int val in arr)
            {
                sum += val;
            }

            WriteOutput(sum.ToString());
        }
        #endregion

        #region Compare the Triplets
        [Problem(_category, _section, "CompareTheTriplets")]
        public void CompareTheTripletsMain()
        {
            int[] aliceScores = new int[] { 5, 6 ,7};
            int[] bobScores = new int[] { 3, 6, 10 };

            CompareTheTriplets(aliceScores, bobScores);
        }

        private void CompareTheTriplets(int[] tokens_a0, int[] tokens_b0)
        {
            int aliceTotalScore = 0;
            int bobTotalScore = 0;

            if(tokens_a0.Length != tokens_b0.Length)
            {
                throw new Exception("The score list be of equal length");
            }

            for (int i = 0; i < tokens_a0.Length; i++)
            {
                if (tokens_a0[i] > tokens_b0[i])
                {
                    aliceTotalScore++;
                }
                else if (tokens_a0[i] < tokens_b0[i])
                {
                    bobTotalScore++;
                }
            }
            WriteOutput($"{aliceTotalScore} {bobTotalScore}");
        }

        #endregion

        #region Diagonal Difference
        [Problem(_category, _section, "DiagonalDifference")]
        public void DiagonalDifferenceMain()
        {
            int[] row0 = new int[] { 11, 2, 4 };
            int[] row1 = new int[] { 4, 5, 6} ;
            int[] row2 = new int[] { 10, 8, -12 };

            int[][] matrix = new int[][]
            {
                row0,
                row1,
                row2
            };

            DiagonalDifference(matrix, 3);
            DiagonalDifferenceEnhanced(matrix, 3);
        }

        public void DiagonalDifference(int[][] a, int n)
        {
            Stopwatch.StartNew();

            int rowNumber = n;
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            // Primary
            for (int i = 0; i < rowNumber; i++)
            {
                primaryDiagonalSum += a[i][i];
            }

            // Secondary
            int maxCol = rowNumber - 1;
            for (int i = 0; i < rowNumber; i++)
            {
                secondaryDiagonalSum += a[i][maxCol];
                maxCol--;
            }

            long timeSpent = Stopwatch.GetTimestamp();
            WriteOutput($"Original: {Math.Abs(primaryDiagonalSum - secondaryDiagonalSum)}", timeSpent);
        }

        public void DiagonalDifferenceEnhanced(int[][] a, int n)
        {
            Stopwatch.StartNew();

            int rowNumber = n;
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            int maxCol = rowNumber - 1;
            for (int i = 0, j = maxCol; i < rowNumber && maxCol >=0; i++, j--)
            {
                primaryDiagonalSum += a[i][i];
                secondaryDiagonalSum += a[i][j];
                maxCol--;
            }

            long timeSpent = Stopwatch.GetTimestamp();
            WriteOutput($"Enhanced: {Math.Abs(primaryDiagonalSum - secondaryDiagonalSum)}", timeSpent);
        }
        #endregion

        public override void Run()
        {
            base.Run(this);
        }
    }
}
