using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class9
    {
        public abstract class Cals<T>
        {
            public abstract T Add(T x, T y);
            public abstract T Sub(T x, T y);

        }
        public class IntCalc:Cals<int>

        {
            public override  int Add(int x,int y)
            {
                return x + y;
            }
            public override int Sub(int x, int y)
            {
                return x - y;
            }
        }
        public class StaticDemo<T>
        {
            public static int x;                          
        }
        static void Main()
        {
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            Console.WriteLine(StaticDemo<string>.x);
            Console.WriteLine(StaticDemo<int>.x);
        }
    }
}
