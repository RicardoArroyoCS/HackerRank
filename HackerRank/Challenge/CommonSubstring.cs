using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class CommonSubstring
    {
        public static void commonSubstring(string[] a, string[] b)
        {
            if(a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i].Contains(b[i]))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}
