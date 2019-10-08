//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    class Class11
//    {
//        struct Currency
//        {
//            public uint Dollars;
//            public ushort Cents;
//            public Currency(uint dollars, ushort cents)
//            {
//                this.Dollars = dollars;
//                this.Cents = cents;
//            }
//            public override string ToString()
//            {
//                return String.Format("${0}.{1,2:00}", Dollars, Cents);
//            }
//            public static string GetCurrencyUnit()
//            {
//                return "Dollar";
//            }
//            public static explicit operator Currency(float value)
//            {
//                checked
//                {
//                    uint dollars = (uint)value;
//                    ushort cents = (ushort)((value - dollars) * 100);
//                    return new Currency(dollars, cents);
//                }
//            }
//            public static implicit operator float(Currency value)
//            {
//                return value.Dollars + (value.Cents / 100.0f);
//            }
//            public static implicit operator Currency(uint value)
//            {
//                return new Currency(value, 0);
//            }
//            public static implicit operator uint(Currency value)
//            {
//                return value.Dollars;
//            }
//        }
//        private delegate string GetAstring();
//        static void Main()
//        {
//            int x = 40;
//            GetAstring firstStringMethod = x.ToString;
//            Console.WriteLine("String is {0}",firstStringMethod());
//            Currency balance = new Currency(34, 50);
//            firstStringMethod = balance.ToString;
           
//            Console.WriteLine("String is{0}",firstStringMethod() );
//            firstStringMethod = new GetAstring(Currency.GetCurrencyUnit);
//            Console.WriteLine("String is{0}", firstStringMethod());
//            Console.ReadLine();
//        }

//    }
//}
