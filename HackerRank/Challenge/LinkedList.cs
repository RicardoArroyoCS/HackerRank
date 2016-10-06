using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge
{
    public class LinkedList
    {
        public LinkedList(int value)
        {
            Value = value;
        }

        public int Value
        {
            get;
            set;
        }

        public LinkedList Next
        {
            get;
            set;
        }
    }

    public class LinkedListUtil
    {
        public static LinkedList RemoveOdds1(LinkedList head)
        {
            // Does not work because keeps reference to old head. Cannot be reassigned by new operator for variable
            LinkedList current = head;

            while(current != null)
            {
                if (IsNodeOdd(current) && current.Next != null)
                {
                    LinkedList temp = new LinkedList(current.Next.Value);
                    temp.Next = current.Next.Next;
                    current = temp;
                }
                else
                {
                    current = current.Next;
                }
            }

            return head;
        }

        public static LinkedList RemoveOdds2(LinkedList head)
        {
            LinkedList current = head;
            LinkedList answerHead = null;

            while (current != null)
            {
                if (IsNodeOdd(current))
                {
                    if(current.Next != null)
                    {
                        LinkedList temp = new LinkedList(current.Next.Value);
                        temp.Next = current.Next.Next;
                        current = temp;
                    }
                    else
                    {
                        current = null;
                    }

                }
                else
                {
                    if(answerHead == null)
                    {
                        answerHead = current;
                    }
                    current = current.Next;
                }
            }

            return answerHead;
        }

        public static bool IsNodeOdd(LinkedList node)
        {
            return node.Value % 2 != 0;
        }

        public static LinkedList CreateLinkedList(int[] values)
        {
            LinkedList head = null;
            LinkedList current = null;
            foreach(int value in values)
            {
                if(head == null)
                {
                    head = new LinkedList(value);
                    current = head;
                }
                else
                {
                    LinkedList next = (current.Next = new LinkedList(value));
                    current = current.Next;
                }
            }
            return head;
        }
    }
}
