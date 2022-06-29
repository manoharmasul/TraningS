using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace TraningS
{
    class ThreadingDemo
    {
        public void m1()
        {
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning");
            ThreadingDemo obj = new ThreadingDemo();
            Thread t1 =new Thread(obj.m1);
            Thread t2 = new Thread(obj.m1);
            for(int i=11;11<=20;i++)
            {
                Console.WriteLine("main"+i);
            }
            Console.WriteLine("main Ends");


        }
    }
}
