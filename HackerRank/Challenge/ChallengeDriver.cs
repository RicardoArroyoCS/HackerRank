using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Challenge
{
    public static class ChallengeDriver
    {
        public static void Run()
        {
            LinkedList();
            MergeString();
        }

        private static void MergeString()
        {
            MergedString mg = new MergedString();
            string result = MergedString.mergeStrings("ab", "zsd");
            Console.WriteLine(result);
        }

        private static void LinkedList()
        {
            SinglyLinkedList results;

            SinglyLinkedList list = new SinglyLinkedList(1);
            SinglyLinkedList current = list;

            for (int i = 2; i <= 100; i++)
            {
                current.Next = new SinglyLinkedList(i);
                current = current.Next;
            }

            results = LinkedListUtil.RemoveOdds(list);

            LinkedListUtil.PrintChildrenToConsole(results);
            Console.WriteLine();

            results = LinkedListUtil.RemoveOddsv2(list);

            LinkedListUtil.PrintChildrenToConsole(results);
            Console.WriteLine();
        }
    }
    


}
