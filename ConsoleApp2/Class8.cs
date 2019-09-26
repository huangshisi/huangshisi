//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    class gouzuohanshu
//    { 
//    public abstract class GenericCustomer
//    {
//        private string name;
//        public GenericCustomer()
//        {
//            name = "<no name>";
//        }
//        public GenericCustomer(string name)
//        {
//            this.name = name;
//        }
//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }

//        }

          
//        }
//    class Nevermore60Customer : GenericCustomer
//    {
//        private uint highCostMinutesUsed;
//        private string referremer;

//        public Nevermore60Customer()
//        {
//        }

//        public Nevermore60Customer(string name) : base(name)
//        {

//        }
//        public Nevermore60Customer(string name, string referremer) : base(name)
//        {
//            this.referremer = referremer;
//        }


//    }
//    class C
//    {
//        public static void Main()
//        {
//            GenericCustomer customer = new Nevermore60Customer();
                

//        }
//    }
//    }
//}
