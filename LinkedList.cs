using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;

namespace GsPractice
{

    public class LinkedList
    {
        public Node Head;
        public Node Tail;



        public void AddLast(int item)
        {
            Node newnode = new Node(item);
            if (IsEmpty())
            {
                Head = Tail = newnode;
            }
            else
            {
                Tail.Next = newnode;
                Tail = newnode;
            }
        }

        private bool IsEmpty()
        {
            return Head == null;
        }

        public void AddFirst(int item)
        {
            Node newnode = new Node(item);
            if (IsEmpty())
            {
                Head = Tail = newnode;
            }
            else
            {
                newnode.Next = Head;
                Head = newnode;
            }
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }
            var second = Head.Next;
            Head.Next = null;
            Head = second;

            
        }

        public void RemoveLast()
        {
          if (IsEmpty())
            {

                throw new InvalidOperationException();
            }
            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }
            var  previous = getPreviousNode(Tail);
         

        }

        private Node getPreviousNode(Node current)
        {
            current = Head;
            while (current != null)
            {
                if (current.Next == Tail)
                    return current; 
                current = current.Next;
            }

            return null;
        }

        public int indexOf(int item)
        {
            int index = 0;
            var current = Head;
            while (current != null)
            {
                if (current.Value == item)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;


        }

        public bool Contains(int item)
        {

            return indexOf(item) != -1;
        }

        public void ReverseLinkedList()
        {
            if (IsEmpty()) return;
            var first = Head; // this is the head
            var second = Head.Next; // this is the reference after the head
           

            while (second != null) //  id the reference in the head is not null
            {
                var next = second.Next; 
                second.Next = first; // changing the refernce to the firs node 
                first = second; // changing the first node to the second (the reference is the first)
                second = next; // changing the second node to the third
            }
            var last = Head;
            last.Next = null;
            Head = first;

        }

        public int kthnode(int k)
        {
            var a = Head;
            var b = Head;

            for (int i = 0; i < k-1; i++)
            {
                b = b.Next;
            }
            while (b != Tail)
            {
                a = a.Next;
                b = b.Next;
            }

            return a.Value;
        }
        public int kthnodelong(int k)
        {
            var a = Head;
            var b = Tail;
            var count = 1;

          while(Head.Next != null)
            {
                Head = Head.Next;
                count = count + 1;
            }

            for (int i = 0; i < count - k; i++)
            {
                a = a.Next;
                if (a == null)
                {
                    break;
                }
            }
            return a.Value;
           
        }



    }
}
