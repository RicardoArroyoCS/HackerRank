using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Challenge
{
    public class SinglyLinkedList
    {
        public SinglyLinkedList(int value)
        {
            Value = value;
        }

        public int Value
        {
            get;
            set;
        }

        public SinglyLinkedList Next
        {
            get;
            set;
        }
    }

    public class LinkedListUtil
    {
        public static SinglyLinkedList RemoveOdds(SinglyLinkedList head)
        {
            SinglyLinkedList current = head;
            SinglyLinkedList answerHead = null;
            SinglyLinkedList answerHeadItr = new SinglyLinkedList(0);

            if(head == null)
            {
                return null;
            }

            while (current != null)
            {
                if (!IsNodeOdd(current))
                {
                    if (answerHead == null)
                    {
                        answerHeadItr = current;
                        answerHead = answerHeadItr;
                    }
                    else
                    {
                        answerHeadItr.Next = current;
                        answerHeadItr = answerHeadItr.Next;
                    }
                }
                else
                {
                    answerHeadItr.Next = null;
                }

                current = current.Next;
            }

            return answerHead;
        }

        public static SinglyLinkedList RemoveOddsv2(SinglyLinkedList list)
        {
            SinglyLinkedList head = null;
            SinglyLinkedList headItr = null;
            SinglyLinkedList current = list;
            bool isHeadSet = false;

            if (list == null)
            {
                return null;
            }

            if (!IsNodeOdd(list))
            {
                isHeadSet = true;
                headItr = new SinglyLinkedList(current.Value);
                head = headItr;
            }

            while (current.Next != null)
            {
                current = current.Next;

                if (!IsNodeOdd(current))
                {
                    if (!isHeadSet)
                    {
                        headItr = new SinglyLinkedList(current.Value);
                        head = headItr;
                        isHeadSet = true;
                    }
                    else
                    {
                        headItr.Next = new SinglyLinkedList(current.Value);
                        headItr = headItr.Next;
                    }
                }
                else
                {
                    headItr.Next = null;
                }
            }

            return head;
        }

        public static bool IsNodeOdd(SinglyLinkedList node)
        {
            return node.Value % 2 != 0;
        }

        public static SinglyLinkedList CreateLinkedList(int[] values)
        {
            SinglyLinkedList head = null;
            SinglyLinkedList current = null;
            foreach(int value in values)
            {
                if(head == null)
                {
                    head = new SinglyLinkedList(value);
                    current = head;
                }
                else
                {
                    SinglyLinkedList next = (current.Next = new SinglyLinkedList(value));
                    current = current.Next;
                }
            }
            return head;
        }

        public static int PrintChildrenToConsole(SinglyLinkedList node)
        {
            if (node == null)
            {
                return 1;
            }
            Console.Write($" {node.Value} ");
            return PrintChildrenToConsole(node.Next);
        }
    }
}
