using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class10
    {
        static void Main()
        {
            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                intArray1.SetValue(33, i);
            }
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(intArray1.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
