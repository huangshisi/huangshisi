using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace ConsoleApp2
{
    class Class11
    {
      struct Vector
        {
            public double x, y, z;
            public Vector (double x,double y,double  z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public Vector (Vector rhs)
            {
                x = rhs.x;
                y = rhs.y;
                z = rhs.z;
            }
            public override string ToString()
            {
                return" ("+x+","+y+","+z+")";
            }
            public static Vector operator +(Vector lhs, Vector rhs)
            {
                Vector result = new Vector(lhs);
                result.x += rhs.x;
                result.y += rhs.y;
                result.z += rhs.z;
                return  result;
            }
            public static Vector operator*(double lhs,Vector rhs)
            {
                return new Vector(lhs * rhs.x, lhs * rhs.y, lhs *rhs .z) ;
            }
            public static Vector operator*(Vector lhs,double rhs)
            {
                return new Vector(rhs*lhs);
            }
             public static double operator*(Vector lhs,Vector rhs)
            {
                return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z; 
            }
            static void Main()
            {
                Vector vector1, vector2, vector3;
                vector1 = new Vector(1.0, 1.5, 2.0);
                vector2 = new Vector(0.0, 0.0, -10.0);
                vector3 = vector1 + vector2;
                Console.WriteLine("vector1=" + vector1);
                Console.WriteLine("vector2=" + vector2);
                Console.WriteLine("vector3=vector1+vector2=" + vector3);
                Console.WriteLine("2*vector3 ="+2*vector3);
                vector3 += vector2;
                Console.WriteLine("vect3=vect2 gives"+vector3);
                vector3 = vector1 * 2;
                Console.WriteLine("Setting vect3=vect1*2 gives"+vector3);
                double dot = vector1 * vector3;
                Console.WriteLine("vect1*vect3="+dot);
                Console.ReadLine();
            }
        }
    }
}
