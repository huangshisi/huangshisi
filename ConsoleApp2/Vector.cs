//using System;
//using System.Collections.Generic;
//using System.Drawing.Drawing2D;
//using System.Numerics;
//using System.Text;

//namespace ConsoleApp2
//{
//    struct Vector
//    {
//        public double x, y, z;
//        public Vector(double x, double y, double z)
//        {
//            this.x = x;
//            this.y = y;
//            this.z = z;
//        }
//        public Vector(Vector rhs)
//        {
//            x = rhs.x;
//            y = rhs.y;
//            z = rhs.z;

//        }
//        public override string ToString()
//        {
//            return "(" + x + "," + y + "," + z + ")";
//        }
//        public static Vector operator +(Vector lhs, Vector rhs)
//        {
//            Vector result = new Vector(lhs);
//            result.x += rhs.x;
//            result.y += rhs.y;
//            result.z += rhs.z;
//            return result;
//        }
//        public static Vector operator *(double lhs,Vector rhs)
//        {
//            return new Vector(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
//        }

//        static void Main()
//        {
//            Vector vector1, vector2, vector3;
//            double a = 1, b;
//            vector1 = new Vector(3.0, 3.0, 1.0);
//            vector2 = new Vector(2.0, 4.0, -4.0);
//            vector3 = vector1 + vector2;
//            b = 2 * a;
//            Console.WriteLine("vector1=" + vector1.ToString());
//            Console.WriteLine("vector2=" + vector2.ToString());
//            Console.WriteLine("vector3=" + vector3.ToString());
//            Console.WriteLine("a"+a.ToString());
//            Console.WriteLine("b=" + b.ToString());
//            Console.ReadLine();




//        }
//    }
//}
