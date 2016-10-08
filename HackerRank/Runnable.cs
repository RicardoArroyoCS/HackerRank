using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HackerRank
{
    public abstract class Runnable
    {
        protected void Run(Object obj)
        {
            MethodInfo[] methods = obj.GetType().GetMethods().
                Where(m => m.GetCustomAttributes(typeof(ProblemAttribute), false).Length > 0).ToArray();

            foreach (MethodInfo method in methods)
            {
                method.Invoke(this, null);
            }
        }
    }
}
