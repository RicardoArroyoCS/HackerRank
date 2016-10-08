using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HackerRank.Algorithms
{
    public abstract class AlgorithmCategory: Runnable, ICategory
    {
        protected const string _category = "Algorithm";

        public abstract void Run();
    }
}
