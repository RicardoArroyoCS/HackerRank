using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HackerRank
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MergedString mg = new MergedString();
            string result = MergedString.mergeStrings("ab", "zsd");
            Console.WriteLine(result);
        }


    }
}
