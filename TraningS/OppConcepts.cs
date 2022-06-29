using System;
using System.Collections.Generic;
using System.Text;
namespace TraningS
{
    //overloding
    class Numeric
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition =" + (a + b));
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition =" + (a + b + c));
        }
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
    class Testttt
    {
        static void Main(string[] args)
        {
            Numeric obj = new Numeric();
            Console.WriteLine("How Many No u Want to add");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 2)
            {
                //  Numeric obj = new Numeric();
                Console.WriteLine("Enter 1st No");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd No");
                int n2 = Convert.ToInt32(Console.ReadLine());
                obj.Add(n1, n2);

            }
            else if (num == 3)
            {
                //Numeric obj=new 
                Console.WriteLine("Enter 1st No");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd No");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 3rd No");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 4th No");
                //int n4 = Convert.ToInt32(Console.ReadLine());
                obj.Add(n1, n2, n3);

            }
            else if (num == 4)
            {
                Console.WriteLine("Enter 1st No");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd No");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 3rd No");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 4th No");
                int n4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(obj.Add(n1, n2, n3, n4));
            }
            else
            {
                Console.WriteLine("No must be beetween 2 to 4");
            }


        }
    }
    class OppBasicDemo
  {
    }
       //classes and objects
    class Moblie
    {
        int Price;
        string Storage;
        string Colour;
        public void calling()
        {
            Console.WriteLine("Voice Calling ");
        }
        public void msg()
        {
            Console.WriteLine("Text msg");
        }
        public void music()
        {
            Console.WriteLine("songs");
        }
        static void Main(string[] args)
        {
            Moblie obj = new Moblie();
            obj.Price = 20000;
            obj.Storage = "8 Gb RAM";
            obj.Colour = "Black";
            Console.WriteLine("Price"+":"+obj.Price);
            Console.WriteLine("Storage"+":"+obj.Storage);
            Console.WriteLine("Colour"+obj.Colour);
            obj.calling();
            obj.msg();
            obj.music();
        }
    }
   //Constructor 
   class A
    {
        int num;
        public A()//Default Constructor
        {
            num = 100;
            Console.WriteLine("in Default Constructor");
        }
        public void Show()
        {
            Console.WriteLine("in Show");
        }
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine(obj.num);
            obj.Show();

        }
    }
    class AA
    {
        public AA(int roll,string name)
        {
            Console.WriteLine(roll+":"+name);
        }
        static void Main(string[] args)
        {
            AA obj = new AA(60,"Manohari");

        }
    }
class EncpsulationDemo
    {
        private int AtmPin;
        public int getreturn()
        {
            return AtmPin;
        }
        public void setvalue(int pin)
        {
            AtmPin = pin;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            EncpsulationDemo obj = new EncpsulationDemo();

                obj.setvalue(7867);
            Console.WriteLine(obj.getreturn());
            //   Console.WriteLine(obj.AtmPin);//not possible
           //// Test obj1 = new Test();
          //  obj1.setvalue(7867);
          //  Console.WriteLine(obj1.getreturn());


        }
    }
    //Inhritance
    //simple inheritance

    class Parent 
    {
        public int a = 10;
        public int b = 20;
        public void Add()
        {
            int z = a + b;
            Console.WriteLine(z);
        }
        public void Sub()
        {
            int z = a - b;
            Console.WriteLine(z);
        }
    }
    class Child:Parent
    {
        public void Mult()
        {
            int z = a * b;

            Console.WriteLine(z);
        }
    }
    class testc
    {
       
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Add();
            obj.Sub();
            obj.Mult();
        }
    }
   
    //multiple inheritance
    interface AAA
    {
        void Add();//public
        void Sub();

    }
    interface BBB
    {
        void Mult();
    }
    class CCC:AAA,BBB
    {
        public void Add()
        {
            int a = 10, b = 20;
            Console.WriteLine(a + b);
        }
        public void Sub()
        {
            int a = 10, b = 20;
            Console.WriteLine(a - b);
        }
        public void Mult()
        {
            int a = 10, b = 20;
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            CCC obj = new CCC();
            obj.Add();
            obj.Sub();
            obj.Mult();

        }
    }
    //Polymorphism 
    class PP
    {
       
        public void Add(int a)
        {
            Console.WriteLine("1st");
        }
        public void Add(int a,int b)
        {
            Console.WriteLine("2nd ");
        }
    }
    class Maint
    {
        static void Main(string[] args)
        {
            PP obj = new PP();
            obj.Add(3, 4);
            obj.Add(5);

        }
    }
    class Ppp
    {
        public virtual void show()
        {
            Console.WriteLine("in Ppp");
        }
    }
    class Ccc:Ppp
    {
        public override void show()
        {
           
            Console.WriteLine("in Ccc");
        }

    }
    class Mmmm
    {
        static void Main(string[] args)
        {
            Ppp obj = new Ccc();
            obj.show();

        }
    }
   

}

