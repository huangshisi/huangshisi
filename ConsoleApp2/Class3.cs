using System;
using System.Collections.Generic;
using System.Text;

//namespace ConsoleApp2
//{
    //class MainEntryPoint
    //{
    //    class MathTest
    //    {
    //        public int value;
    //        public int GetSquare()
    //        {
    //            return value * value;
    //        }
    //        public static int GetSquareOf(int x)
    //        {
    //            return x * x;
    //        }
    //        public static double GetPi()

    //        {
    //            return 3.14;
    //        }
    //    }
    //    static void Main()
    //    {
    //        WeakReference weakReference = new WeakReference(new MathTest ());
    //        MathTest math;
    //        if (weakReference .IsAlive )
    //        {
    //            math = weakReference.Target as MathTest;
    //            math.value = 30;
    //            Console.WriteLine("" + MathTest.GetPi());
    //            Console.WriteLine("square is" + math.GetSquare());

    //        }
    //        else
    //        {
    //            Console.WriteLine("1");
    //        }
    //        GC.Collect();
    //            if (weakReference .IsAlive )
    //        {
    //            math = weakReference.Target as MathTest;
    //        }else
    //        {
    //            Console.WriteLine("1");
    //        }
    //    }
    //}
//    class Protest
//    {
//        static void SomeFunction(int[] ints ,int i )
//        {
//            ints[0]= 100;
//            i = 100;
//        }
//        static void Main()
//        {
//            int i = 0;
//            int[] ints = { 0, 1, 2, 4, 8 };
//            Console.WriteLine("i" + i);
//            Console.WriteLine("ints[0]"+ints[0]);
//            Console.WriteLine("Calling someFunction");
//            SomeFunction(ints,i);
//            Console.WriteLine("i"+i);
//            Console.WriteLine("int[0]"+ints[0]);

//        }
//    }
//}