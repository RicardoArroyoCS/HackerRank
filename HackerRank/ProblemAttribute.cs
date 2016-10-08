using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class ProblemAttribute: Attribute
    {
        public ProblemAttribute(string category, string section)
        {
            Category = category;
            Section = section;
        }

        public string Category
        {
            get;
        }

        public string Section
        {
            get;
        }
    }
}
