using System;

namespace CSharp.Logic
{

    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        public Node head;

        public void printAllNodes(Node current)
        {
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public Node ReverseNew(Node prev, Node cur, Node hh)
        {
            if (cur == null)
                return hh;
            hh = new Node();
            ReverseNew(cur, cur.next, hh.next);
            hh.next = new Node() { data = prev.data };

            return hh.next;
        }
    }

    class Program
    {
        static void Main123(string[] args)
        {
            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast(1);
            myList2.AddLast(2);
            myList2.AddLast(3);
            myList2.AddLast(4);
            myList2.printAllNodes(myList2.head);
            var data = myList2.ReverseNew(null, myList2.head, new Node());
            myList2.printAllNodes(data);



            Console.ReadLine();
        }
    }
}
