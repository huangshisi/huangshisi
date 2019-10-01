//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    class Class11
//    {
//        internal class Person
//        {
//            public string FirstName { get; internal set; }
//            public string LastName { get; internal set; }
//        }
//        static Person []GetPersons()
//        {
//            return new Person[]
//            {
//                new Person {FirstName ="Damon",LastName ="Hill"},
//                new Person {FirstName ="Niki",LastName ="Lauda"},
//                new Person {FirstName ="Ayrton",LastName ="Sonna"},
//                new Person {FirstName ="Graham",LastName ="Hill"}
//            };
//        }
//        static void Main(Person []persons)

//        {
            
//            Array.Sort(persons);
//            foreach (Person p in persons )
//            {
//                Console.WriteLine(p);
//            }
            
//        }
//        static void Main()
//        {
//            SortName();
//            Person[] persons = GetPersons();
//            SortPersons(persons);
//            Console.WriteLine();
          
//            Console.ReadLine();
//        }

//        private static void SortName()
//        {
//            throw new NotImplementedException();
//        }

//        private static void SortPersons(Person[] persons)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
