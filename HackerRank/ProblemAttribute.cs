using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class ProblemAttribute: Attribute
    {
        public ProblemAttribute()
        {
        }

        public ProblemAttribute(string category, string section, string testName)
        {
            ValidateArguments(category, section, testName);

            Category = category;
            Section = section;
            TestName = testName;
        }

        private void ValidateArguments(string category, string section, string testName)
        {
            if (string.IsNullOrEmpty(category))
            {
                throw new ArgumentNullException((nameof(category)));
            }
            if (string.IsNullOrEmpty(section))
            {
                throw new ArgumentNullException((nameof(section)));
            }
            if (string.IsNullOrEmpty(testName))
            {
                throw new ArgumentNullException((nameof(testName)));
            }
        }

        public string Category
        {
            get;
        }

        public string Section
        {
            get;
        }

        public object TestName
        {
            get;
        }
    }
}
