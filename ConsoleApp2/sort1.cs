//using System;

//namespace ConsoleApp2
//{
//    public class Person : IComparable<Person>
//    {
//        public string FirstName { get; set; }

//        public string LastName { get; set; }

//        public override string ToString()
//        {
//            return String.Format("{0} {1}",
//                  FirstName, LastName);
//        }

//        public int CompareTo(Person other)
//        {
//            if (other == null) throw new ArgumentNullException("other");

//            int result = this.LastName.CompareTo(other.LastName);
//            if (result == 0)
//            {
//                result = this.FirstName.CompareTo(other.FirstName);
//            }

//            return result;
//        }
//        static void Main()
//        {
//            Person[] persons = {new Person {FirstName="Damon",LastName="Hili"},
//  new Person {FirstName ="Niki",LastName="Lauda"},
//   new Person {FirstName ="Ayrton",LastName="Senna"},
//   new Person {FirstName ="Grahan",LastName ="Hili"} };
//            Array.Sort(persons);
//                foreach (var p in persons)
//            {
//                Console.WriteLine(p);
//            }
//            Console.ReadLine();
//        }
        

//    }
//}