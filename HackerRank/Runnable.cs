using System;
using System.Linq;
using System.Reflection;
using AttributeRunner;

namespace HackerRank
{
    public abstract class Runnable : AttributeRunner<ProblemAttribute>
    {
        public Runnable()
            : base(new ProblemAttribute())
        {
            base.OnBeforeRunMethod += Runnable_OnBeforeRunMethod;
        }

        private void Runnable_OnBeforeRunMethod(object sender, AttributeEventArgs e)
        {
            ProblemAttribute foundAttribute = e.FoundAttribute as ProblemAttribute;
            if (foundAttribute != null)
            {
                Console.WriteLine($"Running: {foundAttribute.Category}:{foundAttribute.Section} - {foundAttribute.TestName}");
            }
        }

        protected void WriteOutput(string output)
        {
            Console.WriteLine($"Output: {output}");
        }
    }
}
