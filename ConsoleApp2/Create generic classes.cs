using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Creategenericclasses
    {
        public class LinkedListNode<T>
        {
            public LinkedListNode(T value)
            {
                this.Value = value;
            }
            public T Value { get; internal set; }
            public LinkedListNode<T> Next { get; internal set; }
            public LinkedListNode<T> Prev { get; internal set; }
        }
        public class LinkedList<T> : IEnumerable<T>
        {
            public LinkedListNode<T> First { get; private set; }
            public LinkedListNode<T> Last { get; private set; }
            public LinkedListNode<T> AddLast(T node)
            {
                var newNode = new LinkedListNode<T>(node);


                if (First == null)
                {
                    First = newNode;
                    Last = First;
                }
                else
                {
                    LinkedListNode<T> previous = Last;
                    Last.Next = newNode;
                    Last = newNode;
                    Last.Prev = previous;

                }
                return newNode;


            }
            public IEnumerator<T> GetEnumerator()
            {
                LinkedListNode<T> curent = First;
                while (curent != null)
                {
                    yield return curent.Value;
                    curent = curent.Next;
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }


        }
        static void Main()
        {
            var List2 = new LinkedList<int>();
            List2.AddLast(1);
            List2.AddLast(3);
            List2.AddLast(5);
            foreach (int i in List2 )
            {
                Console.WriteLine(i);
            }
        }
    }
}
