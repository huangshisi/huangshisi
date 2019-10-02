//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    class 

//    {
//      public class Shape

//        {
//            public double width { get; set; }
//            public double Height { get; set; }
//            public override string ToString()
//            {
//                return String .Format ("width:{0},Height:{1}",width ,Height);

//            }

//        }
//        public class Rectangle:Shape
//        {

//        }
//        public interface IIndex<out T>
//        {
//            T this[int index] { get; }
//            int Count { get; }
//        }
//        public class RectangleCollection:IIndex<Rectangle>
//        {
//            private Rectangle[] data = new Rectangle[3]
//            {
//                new Rectangle {Height =2,width =5},
//                new Rectangle {Height =3,width =7},
//                new Rectangle {Height =4.5,width =2.9}
//            };
//            private static RectangleCollection coll;
//            public static RectangleCollection GetRectangles()
//            {
//                return coll ?? (coll =new RectangleCollection ());

//            }
//            public Rectangle this[int index]
//            {
//                get
//                {
//                    if (index < 0 || index > data.Length)
//                        throw new ArgumentOutOfRangeException("index");
//                    return data[index];

//                }
//            }
//            public int Count
//            {
//                get
//                {
//                    return data.Length;
//                }
//            }

//        }
//        static void Main()
//        {
//            IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
//            IIndex<Shape> shapes = rectangles;
//            for(int i=0;i<shapes .Count;i++)
//            {
//                Console.WriteLine(shapes[i]);
//            }
//        }
//    }
//}
