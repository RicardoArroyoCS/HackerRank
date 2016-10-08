using System;
using System.Collections.Generic;
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

        public override void Run()
        {
            base.Run(this);
        }
    }
}
