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
}
