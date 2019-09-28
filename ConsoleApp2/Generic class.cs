//using Boxing;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    class Generic 
//    {
//        public class LinkedListNode
//        {
//            public object Value { get; set; }
//            public LinkedListNode Next { get; set; }
//            public LinkedListNode Prev { get; set; }

//            public LinkedListNode (object value)
//            {
//                this.Value = value;
//            }


//        }
//        public class LinkedList : IEnumerable
//        {
//            public LinkedListNode First { get; private set; }
//            public LinkedListNode Last { get; private set; }
//            public LinkedListNode AddLsat(object node)
//            {
//                var newNode = new LinkedListNode(node);
//                if (First ==null)
//                {
//                    First = newNode;
//                    Last = First;
//                }
//                else
//                {
//                    LinkedListNode previous = Last;
//                    Last.Next = newNode;
//                    Last.Prev = previous;
//                    Last = newNode;
//                }
//                return newNode;
//            }
//            public IEnumerator GetEnumerator()
//            {
//                LinkedListNode current = First;
//                while (current !=null )
//                {
//                    yield return current.Value;
//                    current = current.Next;
//                }
//            }

//        }
//        static void Main()
//        {
//            var list1 = new LinkedList();
//            list1.AddLsat(2);
//            list1.AddLsat(4);
           
//            foreach (int i in list1 )
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
    
//}
