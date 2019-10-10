using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Mathoperations
    {
        public static void MultiplyByTwo(double value)
        {
            double result = value * 2;
            Console.WriteLine("MultiplyByTwo by 2:{0}gives{1}", value, result);
            
        }
        public static  void Square(double value)
        {
            double result = value * value;
            Console.WriteLine("Squareing:{0} gives{1}", value, result) ;
        }

        static void Main()
        {
            Action<double> operations = Mathoperations.MultiplyByTwo;
            operations += Mathoperations.Square;


            ProcesAndDisplayNumber(operations, 2.0);
            ProcesAndDisplayNumber(operations, 7.94);
            ProcesAndDisplayNumber(operations, 1.414);
            Console.WriteLine();
            Console.ReadLine();
            
        }
        static void ProcesAndDisplayNumber(Action<double>action,double value)
        {
            Console.WriteLine();
            Console.WriteLine("ProcessAndDisplayNumber called with value={0}",value );
            action(value);
        }
    }
}
