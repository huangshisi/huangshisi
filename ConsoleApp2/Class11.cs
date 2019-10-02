using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp2
{
   class Class
    {
        static void Main()
        {
            int x = 5;
            if (++x==6)
            {
                Console.WriteLine("ture");
            }
            else
            {
                Console.WriteLine("false");
            }
            if(++x==7)
            {
                Console.WriteLine("x++7等于7");
            }
            else
            {
                Console.WriteLine("x++不等于7");
            }
            Console.ReadLine();
        } 
           

    }
}
