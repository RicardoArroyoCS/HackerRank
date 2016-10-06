using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class Solution
    {
        public class LinkedListNode
        {
            public int val;
            public LinkedListNode next;
        };

        public static LinkedListNode _insert_node_into_singlylinkedlist(LinkedListNode head, LinkedListNode tail, int val)
        {
            if (head == null)
            {
                head = new LinkedListNode();
                head.val = val;
                head.next = null;
                tail = head;
            }
            else {
                LinkedListNode node = new LinkedListNode();
                node.val = val;
                node.next = null;
                tail.next = node;
                tail = tail.next;
            }
            return tail;
        }

        public class DeleteOdd
        {
            public static LinkedListNode deleteOdd(Solution.LinkedListNode list)
            {
                LinkedListNode toReturnCurrent = new LinkedListNode();
                LinkedListNode head = new LinkedListNode();
                bool isHead = true;

                if (list == null)
                {
                    return list;
                }
                toReturnCurrent = head;

                while (list != null)
                {
                    if(!isOdd(list.val))
                    {
                        if(isHead)
                        {
                            head.val = list.val;
                            isHead = false;
                        }
                        else
                        {
                            LinkedListNode nonOddNode = new LinkedListNode()
                            {
                                val = list.val
                            };

                            toReturnCurrent.next = nonOddNode;
                            toReturnCurrent = toReturnCurrent.next;
                        }

                    }
                    list = list.next;
                }
                return head;
            }

            private static bool isOdd(int value)
            {
                return value % 2 != 0;
            }
        }
    }


}
