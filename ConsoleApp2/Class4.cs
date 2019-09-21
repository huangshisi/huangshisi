using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class4
    {
        public class MathLib
        {
           public int Add(int x,int y)
            {
                return x + y;
               
            }

        }
        public static void Main()
        {
            MathLib mathlib = new MathLib();
            Console.WriteLine(mathlib.Add(7, 8));

        }
    }
}
