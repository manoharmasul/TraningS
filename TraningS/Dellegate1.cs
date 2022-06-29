using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    //defining the delegates 
    public delegate void AddDelegate(int x, int y);
    public delegate string MsgDelegate(string nm);

    class Methods
    {
       
        public void Addnums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string Msg(string name)
        {
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            //call methods using instnace of the class 

             Methods obj = new Methods();
            obj.Addnums(100, 50);
             string str= Methods.Msg("Raju");
            Console.WriteLine(str);
            Console.WriteLine("///////////////////////////////////////");
            //call metthod using delegats
            //define delegate/ modifier voidtype name parameter list 
            AddDelegate ad = new AddDelegate(obj.Addnums);
            ad(10, 40);


            MsgDelegate ad1 = new MsgDelegate(Methods.Msg);
            string str1 = Methods.Msg("manu");
            Console.WriteLine(str1);
        }
    }
    //multicast Delegates delegate holds the refrence of more than one method
    class Dellegate67
    {
        static int add(int a,float b)
        {
            Console.WriteLine("Add"+(a+b));
            return (int)(a + b);
        }
        static void greet(string nm)
        {
            Console.WriteLine("Good Morning " +nm);
        }
        static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;

        }
        static void Main()
        {
            Func<int, float, int> f1 = add;
            int ans = f1(10, 3.4f);
            Action<string> f2 = greet;
            f2("manohari");
            Predicate<int> f3 = IsEven;
            Console.WriteLine(f3(67));

        }
    }
    class AAAA
    {
        //static void filter (List<int> 1st,Predicate<int> p1)
        //{
        //    foreach(int element in 1st)
        //    {
        //        bool b = p1(int element);
        //        if (b == true)
        //            Console.WriteLine(element);
        //    }
        //}
        //static bool iseven(int a)
        //{
        //    return a % 2 == 0;
        //}
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 5,6,7,4,6,8,9,98,76,54,45,23};
            List<int> l2 = new List<int>();
            //foreach(int d in l1)
            //{
            //    if (d % 2 == 0)
            //        l2.Add(d);

            //}
            //callback function
            List<int> l3 = l1.FindAll((a) => a % 2 == 0);

        }
    }
}
