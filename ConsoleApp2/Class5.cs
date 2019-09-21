using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class5
    {

       class MathTest
        {
            public int value; 
            public int Getsquare()
            {
                return value * value;
            }
            public static int Getquareof(int x)
            {
                return x * x;

            }
            public static double GetPi()
            {
                return 3.14;
            }
        }
        static void Main()
        {
            Console.WriteLine("pi is" + MathTest.GetPi());
            int x = MathTest.Getquareof(5);
            Console.WriteLine("quareof 5 is" + x);
            MathTest math = new MathTest();
            math.value = 30;
            Console.WriteLine(math.Getsquare());
        }

    }
}
