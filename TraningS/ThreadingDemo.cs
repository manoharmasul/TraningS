using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace TraningS
{
    //operating system w
    //process runing the appl
    //thred run code inside the code
    //threa is unit which is execut the code inside the code
    //every appl by default contain one threed to excecut the program and that is known as main thred 

    //so every ptogram is by default single threaded model
    
    class ThreadingDemo
    {
        public void m1()
        {
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning");
            ThreadingDemo obj = new ThreadingDemo();
            Thread t1 =new Thread(obj.m1);
            t1.Start();
           

            Thread t2 = new Thread(obj.m1);
            t2.Start();
            for(int i=11;i<=20;i++)
            {
                Console.WriteLine("main"+i);
            }
            Console.WriteLine("main Ends");


        }
    }
    
    class ThreadDemo1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;//currentthred static property returns the refrence current executing threast
            t.Name = "Main Thread";
            Console.WriteLine("current executing thread is "+ Thread.CurrentThread.Name);

        }
    }
    class TeadingDemo2
    {
        static void test1()
        {
            for (int i=0; i<=10;i++)
            {
                Console.WriteLine("test1"+ i);

            }
        }
        static void test2()
        {
            for (int i=11;i<=20;i++)
            {
                Console.WriteLine("test2 "+ i);

                if (i == 5)
                {
                    Console.WriteLine("thread 2 going to sleep");
                    Thread.Sleep(3000);
                    Console.WriteLine("thread 2 woke up");
                }
            }
        }
        static void test3()
        {
            for(int i=21;i<=30;i++)
            {
               Console.WriteLine("test3"+i);
            }
            
        }
        static void Main(string[] args)
        {
            //test1();
            //test2();
            // test3();//here operation take place one after anotherm
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            t1.Start();t2.Start(t2);t3.Start(3);

            Console.WriteLine("the main method is exited");

        }
    }
}
