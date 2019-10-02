using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class11
    {
        public class Person : IEnumerable<Person>
        {
            public int Id { get; private set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public override string ToString()
            {
                return String.Format("{0},{1},{2}", Id, FirstName, LastName);

            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return base.Equals(obj);
                return Equals(obj as Person);
            }
            public override int GetHashCode()
            {
                return Id.GetHashCode();
            }
            public bool Equals(Person other)
            {
                if (other == null)
                    return base.Equals(other);
                return this.Id == other.Id && this.FirstName == other.FirstName && this.LastName == other.LastName;
            }

            public IEnumerator<Person> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        static void Main()
        {
            var janet = new Person { FirstName = "Janet", LastName = "Jackson" };
            Person[] persons1 = { new Person { FirstName = "Michael",LastName ="Jackson" },janet  };
            Person[] persons2 = { new Person { FirstName = "Michae1",LastName ="Jackson"},janet };
            if (persons1!=persons2)
            {
                Console.WriteLine("not the same reference");
                
            }
           
            if ((persons1 as IStructuralEquatable ).Equals (persons2 ,EqualityComparer <Person>.Default))
            {
                Console.WriteLine("the same content");
            }
           var t1=Tuple .Create<int,string> (1, "Stephanie");
            var t2 = Tuple.Create<int, string>(1, "Stephanie");
            if(t1!=t2)
            {
                Console.WriteLine("not the same reference to the tuple");
            }
            Console.ReadLine();
        }
    }
}
