using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class11
    {
        static void Main()
        {
        int[] Array = new int[4] { 4, 7, 11, 2 };
        int[] myArray = new int[] { 4, 7, 11, 2 };
        int v1 = myArray[0];
        int v2 = myArray[1];
        myArray[3]=44;
            for (int i=0;i<myArray .Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }
            foreach (var val in myArray )
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();


        }
    }
}
