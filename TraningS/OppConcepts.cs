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
    /// <summary>
    /// sealeas class Ex
    /// </summary>
    /// 
    class sealedDemo
    {

    }
    sealed class sealedEx:sealedDemo
    {
        public  void Add(int a, int b)
        {
            Console.WriteLine("Add"+(a+b));
        }
    }
    class Normaal//:sealedEx//not possible because of sealed 
    {
        public  void Sub(int a,int b)
        {
            Console.WriteLine("sub "+(a-b));
        }
    }
    class testingDD:Normaal
    { 
        public void Mult(int a,int b)
        {
            Console.WriteLine("mult"+(a*b));
        }
        static void Main(string[] args)
        {
            sealedEx obj = new sealedEx();
            obj.Add(10, 3);
            testingDD obj1= new testingDD();
            obj1.Sub(50, 25);
            obj1.Mult(6 ,6);
           
        }

    }
     class parent
     {
        public virtual void Add(int a, int b)
        {
            Console.WriteLine("P Add");
        }
        public virtual void sub(int a,int b)
        {
            Console.WriteLine("p sub");
        }
     }
     class child:parent
     {
         sealed public override void Add(int a, int b)
          {

            Console.WriteLine("in child Add " );
          }
        public override void sub(int a,int b)
        {
            Console.WriteLine("in child sub");
        }

     }
    class subchild :child
    {
        //override void Add(int a,int b)//not override
        //{

        //}
      public override void sub(int a, int b)
        {
            Console.WriteLine("in sub child sub");
        }
    }
    class tettt
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("calling using parent ");
            parent obj = new parent();
            obj.Add(6, 8);
            obj.Add(10 , 5);
            Console.WriteLine("calling using child  ");
            parent obj1 = new child();
            obj1.Add(10, 29);
            obj1.sub(30, 29);
            Console.WriteLine("using sub child   ");
            parent obj2 = new subchild();
            obj2.sub(58, 8);
            obj2.Add(89, 88);


        }
    }

    class testingDD1: Normaal
    {
        public void Mult(int a, int b)
        {
            Console.WriteLine("mult" + (a * b));
        }
        static void Main(string[] args)
        {
            sealedEx obj = new sealedEx();
            obj.Add(10, 3);
            testingDD obj1 = new testingDD();
            obj1.Sub(50, 25);
            obj1.Mult(6, 6);

        }

    }

    class constructorOverloading
    {
        public int Id;
       public  string Name;
        public constructorOverloading(int id,string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("in first constructor");
        }
        public constructorOverloading(string Name,int Id)
        {
           this. Name = Name;
           this. Id = Id;
            Console.WriteLine("in second Constructor");
        }
        public void show()
        {
            Console.WriteLine("Id " +Id+" Name "+Name) ;
        }
        
    }
    class demo
    {
        static void Main(string[] args)
        {
            constructorOverloading obj = new constructorOverloading(10, "manohar");
            obj.show();
            constructorOverloading obj1 = new constructorOverloading("Jayesh",11);
            obj1.show();
        }
    }
    class CoppyConstructor
    {
        string BookName;
        int Code;
        public CoppyConstructor(string BookName,int Code)
            {
          this.BookName = BookName;
          this.Code = Code;
            }
        public CoppyConstructor(CoppyConstructor tech)
        {
            BookName = tech.BookName;
            Code = tech.Code;
        }
        public string Getdata
        {
            get
            { 
                return "Name of the Book:"+BookName+" And Code is =>"+ Code.ToString();
            }
        }
    }
    class Stest
    {
        static void Main(string[] args)
        {
            CoppyConstructor obj1 = new CoppyConstructor("MasterC#", 101);
            CoppyConstructor obj2 = new CoppyConstructor(obj1);
           
            Console.WriteLine(obj2.Getdata);

        }
    }
    //privagte Construcostor.
    class PrivateConstructorDD
    {
        PrivateConstructorDD() //by default private
        {
            Console.WriteLine("in private Constructor ");
        }
    }
    class privareCtest
    {
        static void Main(string[] args)
        {
           // PrivateConstructorDD obj = new PrivateConstructorDD();  
            //if parameterise constructor is not present

        }
    }
    class privateCDemo
    {
        public static int id;
        public static string name;
       privateCDemo()
        {
            Console.WriteLine("in privatre constructor");
        }
        public privateCDemo(int Id ,string Name)
        {
            id = Id;
            name = Name;
            Console.WriteLine("in parameterized constrctor");
        }
    }
    class privareCtestDemo
    {
        static void Main(string[] args)
        {
            // privateCDemo obj = new privateCDemo();//shows Eror

            privateCDemo obj = new privateCDemo(101, "mansi");
            Console.WriteLine(privateCDemo.name+" "+privateCDemo.id);
        }
    }

}

