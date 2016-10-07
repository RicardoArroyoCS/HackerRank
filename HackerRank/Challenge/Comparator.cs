using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Challenge
{
    public class Comparator
    {
        private const string _different = "Different";
        private const string _same = "Same";

        public string compare(int a, int b)
        {
            return translate(a == b);
        }

        public string compare(string a, string b)
        {
            return translate(a.Equals(b));
        }

        public string compare(int[] a, int[] b)
        {
            bool isEqual = true;

            if ((a.Length > 1 && b.Length > 1) && a.Length == b.Length)
            {

                for (int i = 0; i < a.Length; i++)
                {
                    if (!a[i].Equals(b[i]))
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            else
            {
                isEqual = false;
            }

            return translate(isEqual);
        }

        private string translate(bool equation)
        {
            return equation ? _same : _different;
        }
    }
}
