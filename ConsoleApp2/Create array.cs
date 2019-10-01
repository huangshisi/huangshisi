//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    class Class10
//    {

//        public class Person
//        {
//            public string FirstName { get; set; }
//            public string LastName { get; set; }
//            public override string ToString()
//            {
//                return String.Format("{0},{1}", FirstName, LastName);
//            }
//        }

//        static void Main()
//        {
//            Array intArray1 = Array.CreateInstance(typeof(int), 5);
//            for (int i = 0; i < 5; i++)
//            {
//                intArray1.SetValue(33, i);
//            }
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(intArray1.GetValue(i));
//            }
//            Console.ReadLine();
//            Person[] myPerson = new Person[2];
//            myPerson[0] = new Person { FirstName = "Ayrton", LastName = "Senna" };
//            myPerson[1] = new Person { FirstName = "Michael", LastName = "Sxhumacher" };
//            Person[] myPersons2 =
//            {
//                new Person {FirstName ="Ayrton",LastName ="Senna"},
//            new Person {FirstName ="Michael",LastName="Schumacher"}
//            };
//            int[] intArray2 = (int[])intArray1;
//            int[] lengths = { 2, 3 };
//            int[] lowerBounds = { 1, 10 };
//            Array racers = Array.CreateInstance(typeof(Person), lengths, lowerBounds);
//            racers.SetValue(new Person
//            {
//                FirstName = "Alain",
//                LastName ="Prost"

//            },index1: 1,index2: 10);
//            racers.SetValue(new Person
//            {
//                FirstName = "Emerson",
//                LastName = "Fittipaldi"
//            }, 1, 11);
//            racers.SetValue(new Person
//            {
//                FirstName = "Ayrton",
//                LastName = "Senna"
//            }, 1, 12);
//            racers.SetValue(new Person
//            {
//                FirstName = "Michael",
//                LastName = "Schumacher"

//            }, 2, 10);

//            racers.SetValue(new Person
//            {
//                FirstName = "Fernando",
//                LastName = "Alonso"
//            }, 2, 11);
//            racers.SetValue(new Person
//            {
//                FirstName = "jenson",
//                LastName = "Button"
//            }, 2, 12);
//            Person[,] racers2 = (Person[,])racers;
//            Person first = racers2[1, 10];
//            Person last = racers2[1, 10];
//            int[] intArray1 = ( 1, 2 );
//            int[] intArray2 = (int[])intArray1.Clone();
       
//        }
//    }
//}
