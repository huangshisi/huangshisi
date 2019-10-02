using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class11
    {
        static void Main()
        {
            int myIntNumber = 20;
            object myObject = myIntNumber;
            int mysecondNumber = (int)myIntNumber;
            Console.WriteLine(mysecondNumber);
            Console.ReadLine();
        }
    }
}
