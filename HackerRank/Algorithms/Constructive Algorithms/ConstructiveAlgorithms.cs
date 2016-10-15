using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Constructive_Algorithms
{
    public sealed class ConstructiveAlgorithms : AlgorithmCategory
    {
        private const string _section = "Constructive Algorithms";
        private static readonly ConstructiveAlgorithms _instance = new ConstructiveAlgorithms();

        public static ConstructiveAlgorithms Instance
        {
            get
            {
                return _instance;
            }
        }

        #region Flipping the Matrix
        [Problem(_category, _section, "FlippingTheMatrix")]
        public void FlippingTheMatrix()
        {
             
        }

        #endregion

        #region New Year Chaos
        [Problem(_category, _section, "NewYearChaos")]
        public void NewYearChaos()
        {
            int[] queue1 = new int[] { 2, 1, 5, 3, 4 };
            int[] queue2 = new int[] { 2, 5, 1, 3, 4 };

            NewYearChaos(queue1.Length, queue1);
            NewYearChaos(queue1.Length, queue2);
        }

        private void NewYearChaos(int n, int[] queue1)
        {
            throw new NotImplementedException();
        }

        #endregion

        public override void Run()
        {
            base.Run(this);
        }
    }
}
