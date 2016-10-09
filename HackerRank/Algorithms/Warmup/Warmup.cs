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

        #region Plus Minus
        [Problem(_category, _section, "PlusMinus")]
        public void PlusMinusMain()
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };

            PlusMinus(arr, arr.Length);
        }

        private void PlusMinus(int[] arr, int length)
        {
            int positiveNumbers = 0;
            int negativeNumbers = 0;
            int zeroNumbers = 0;

            foreach(int number in arr)
            {
                if(number == 0)
                {
                    zeroNumbers++;
                }
                else if(number > 0)
                {
                    positiveNumbers++;
                }
                else
                {
                    negativeNumbers++;
                }
            }

            double positveNumberFraction = CalculateFraction(positiveNumbers, length);
            double negativeNumberFraction = CalculateFraction(negativeNumbers, length);
            double zeroNumberFraction = CalculateFraction(zeroNumbers, length);

            Console.WriteLine($"{positveNumberFraction}\n{negativeNumberFraction}\n{zeroNumberFraction}");
        }

        private double CalculateFraction(int number, int total)
        {
            return Math.Round((float)number / (float)total, 6);
        }

        #endregion

        #region Staircase
        [Problem(_category, _section, "Staircase")]
        public void StairCaseMain()
        {
            int staircaseRows = 4;

            Staircase(staircaseRows);
            StaircaseEnhanced(staircaseRows);
        }

        private void Staircase(int n)
        {
            StringBuilder builder = new StringBuilder();
            string spaces = " ";
            string step = "#";
            int numOfSpaces = n - 1;
            string valToAppend = string.Empty;

            Stopwatch.StartNew();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < numOfSpaces; j++)
                {
                    builder.Append(spaces);
                }
                for (int k = 0; k < n - numOfSpaces; k++)
                {
                    builder.Append(step);
                }
                builder.Append("\n");
                numOfSpaces--;
            }

            long timeSpent = Stopwatch.GetTimestamp();

            WriteOutput($"\n{builder.ToString()}", timeSpent);
        }

        private void Staircase2(int n)
        {
            StringBuilder builder = new StringBuilder();
            string spaces = " ";
            string step = "#";
            int numOfSpaces = n - 1;
            string valToAppend = string.Empty;

            Stopwatch.StartNew();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    builder.Append(spaces);
                }
                for (int k = 0; k < i; k++)
                {
                    builder.Append(step);
                }
                builder.Append("\n");
                numOfSpaces--;
            }

            long timeSpent = Stopwatch.GetTimestamp();

            WriteOutput($"\n{builder.ToString()}", timeSpent);
        }

        private void StaircaseEnhanced(int n)
        {
            StringBuilder builder = new StringBuilder();
            string spaces = " ";
            string step = "#";
            int numOfSpaces = n - 1;
            string valueToAppend = string.Empty;

            Stopwatch.StartNew();

            for (int i = 1; i <= n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    if(j < n-i)
                    {
                        valueToAppend = spaces;
                    }
                    else
                    {
                        valueToAppend = step;
                    }

                    builder.Append(valueToAppend);
                }
                builder.Append("\n");
            }

            long timeSpent = Stopwatch.GetTimestamp();

            WriteOutput($"\n{builder.ToString()}", timeSpent);
        }

        #endregion

        public override void Run()
        {
            base.Run(this);
        }
    }
}
