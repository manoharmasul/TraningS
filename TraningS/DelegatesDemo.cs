using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    public delegate int mydelegate1(int n);
    public delegate void mydelegate(string msg, string nm);
    class DelegatesDemo
    {
        static void greet(string msg,string nm)
        {
            Console.WriteLine("Welcome"+msg+","+nm);
        }
        static int factorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact *= i;
            }
            return fact;

        }
        static void Main(string[] args)
        {
            mydelegate d1 = DelegatesDemo.greet;
            d1("Good Morning", "Manohar");


            mydelegate1 d2 = DelegatesDemo.factorial;
            int result = d2(23);
            Console.WriteLine("fact is "+result);

        }
    }
    //
    public delegate void Del(int a, int b);
    class DelDemo2
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Add="+(a+b));
        }
        public static void Sub(int a,int b)
        {
           Console.WriteLine("sub"+ (a-b));

        }
        public static void Mult(int a,int b)
        {
            Console.WriteLine("Mult"+ (a*b));
        }
        static void Main(string[] args)
        {
            Del d1 =Add;
            d1 +=Sub;
            d1 += Mult;
            d1(10,20);

        }
    }
    public delegate void Del3(int a, int b);
    class del3
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine("Add="+ (a+b));
        }
        public static void Substract(int a,int b)
        {
            Console.WriteLine("sub"+ (a-b));
        }
        public static void Main()
        {
            Del3 d1 = delegate (int a, int b)
         {
             Console.WriteLine("anonymous " + (a + b));
             Console.WriteLine("Anonymous"+ (a-b));
         };

        d1(10, 2);
            Console.WriteLine("///////////////////////////////");
            //lamda
            Del3 d2 = (a, b) =>
            {
                Console.WriteLine("lamda="+(a+b));
            };
            d2(5, 3);

            Console.WriteLine("//////////////////////////////");
          //  Del3 d3 = (a, b) => a + b;
            //Console.WriteLine("ans="+ (10,20));

        }
    }

    public delegate int Del6(int a, int b);
    class vvv
    {
        static int add(int a,int b)
        {
            return a + b;

        }
        static void Main(string[] args)
        {
            //////////
            Del6 ob2 = (a, b) => a + b;
            Console.WriteLine("Answer="+ ob2(9,7));

        }
    }
}
