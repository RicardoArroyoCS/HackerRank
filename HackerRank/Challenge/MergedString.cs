using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Challenge
{
    public class MergedString
    {
        public static string mergeStrings(string a, string b)
        {
            string mergedString = string.Empty;
            int indexStopped = 0;

            if(a.Length == 1 && b.Length == 1)
            {
                mergedString = a + b;
            }
            else
            {
                for(int i = 0; i< a.Length && i < b.Length; i++)
                {
                    mergedString += a[i].ToString() + b[i].ToString();
                    indexStopped++;
                }

                if (a.Length != b.Length)
                {
                    if (indexStopped < a.Length)
                    {
                        mergedString += a.Substring(indexStopped);
                    }
                    else
                    {
                        mergedString += b.Substring(indexStopped);
                    }
                }
            }

            return mergedString;
        }
    }
}
