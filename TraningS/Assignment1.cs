using System;
using System.Collections.Generic;
using System.Text;

using System;
    

namespace TraningS
{
    //    Create class Teacher with following

    //    Tid,Tname,MobileNo
    //    Parameterized constructor
    //    abstract void salary()
    //Create class Hourlybased which is derived class from teacher with fields
    //     rate_per_hr,

    //    int hrs;
    //    Parameterized constructor

    //    void salary()
    //Create class SalaryBased which is derived class from teacher
    //    with fields
    //    int salary;
    //    Parameterized constructor

    //    void salary()
    //Write main to create objects of HourlyBased teacher and SalaryBased teacher and also call respective salary method and also show runtime polymorphism



    class Assignment1
    {

    }
    abstract class Teacher
    {
        public int Tid;
        public string Tname;
        public long MobileNo;
        public Teacher(int Tid, string Tname, long MobileNo)
        {
            this.Tid = Tid;
            this.Tname = Tname;
            this.MobileNo = MobileNo;

        }
        public Teacher()
        {
        }
        public abstract void salary();

    }
    class HourBased : Teacher
    {
        int hrs;
        int rateperhrs;
        public HourBased(int Tid, string Tname, long MobileNo, int hrs, int rateperhrs) : base(Tid, Tname, MobileNo)
        {
            this.hrs = hrs;
            this.rateperhrs = rateperhrs;

        }
        public override void salary()
        {

            Console.WriteLine("salary of hrs based techer is" + hrs * rateperhrs);
        }
    }
    class SalaryBased : Teacher
    {
        int sal;
        public SalaryBased(int sal)
        {
            this.sal = sal;
        }
        public override void salary()
        {
            Console.WriteLine("sal of salary based Teacher is" + sal);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Teacher obj1 = new HourBased(4, "manohar", 98235784, 8, 200);
            obj1.salary();
            Teacher obj2 = new SalaryBased(2000);
            obj2.salary();
        }
    }


    interface Cake
    {
        void bake();

    }
    class StrawBerry : Cake
    {
        public void bake()
        {
            Console.WriteLine("in Strawberry");
        }
    }
    class BlackForest : Cake
    {
        public void bake()
        {
            Console.WriteLine("in blackforest");
        }

    }
    class CakeTest
    {
        static void Main(string[] args)
        {
            StrawBerry obj = new StrawBerry();
            obj.bake();
            BlackForest obj1 = new BlackForest();
            obj1.bake();

        }

    }

    interface IIceCream
    {
        void eat();


    }
    interface IJuice
    {
        void drink();

    }

    class Mastani : IIceCream, IJuice
    {
        public void eat()
        {
            Console.WriteLine("mastani is eating");
        }

        public void drink()
        {
            Console.WriteLine("mastani in drinking");
        }
    }
    class MastaniTest
    {
        static void Main(string[] args)
        {
            Mastani obj = new Mastani();
            obj.eat();
            obj.drink();

        }
    }



    //    Design a class to overload a function volume() as follows:  [2M]
    //    (i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
    //v = 4 / 3 × 22 / 7 × r3
    //(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r
    //as the arguments, returns the volume of a cylinder using the formula:
    //v = 22 / 7 × r2 × h
    //(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, returns the volume of a cuboid using the formula:
    //v = l × b × h

    class Volumet
    {

        public double volume(double r)
        {

            double vol = (4 / 3) * (22 / 7) * (r * r * r);
            Console.WriteLine(vol);
            return vol;
        }
        public double volume(double h, double r)
        {
            double vol = (22 / 7) * (r * r) * h;
            Console.WriteLine(vol);
            return vol;
        }
        public double volume(double l, double b, double h)
        {
            double vol = l * b * h;
            Console.WriteLine(vol);
            return vol;
        }
    }
    class Printt
    {
        static void Main(string[] args)
        {
            Volumet obj = new Volumet();
            obj.volume(2.45);

            obj.volume(23.22, 31.355);
            obj.volume(2.5, 3.9, 8.9);

        }
    }
    //  WAP to find Area of Square, Rectangle, and Circle using Method Overloadi
    class AreaDemo
    {
        public void Area(float r)

        {
            Console.WriteLine("Area of circle is" + 3.14 * r * r);
        }
        public void Area(int a)
        {

            Console.WriteLine("Area of Squre" + a * a);
        }
        public void Area(int b, int h)
        {
            Console.WriteLine("Area of rectagle" + b * h);
        }
    }
    class PrintArea
    {
        static void Main(string[] args)
        {
            AreaDemo obj = new AreaDemo();
            obj.Area(5.8f);
            obj.Area(7);
            obj.Area(5, 8);
        }

    }

    class Account12
    {
        public long accountNo;
        public string CustomerName;
        public double Balance;
        public Account12()
        {
            CustomerName = "manohar";
            accountNo = 986987890;
            Balance = 7676.67;
            Console.WriteLine("in Default Construcrtor");
        }
        public Account12(long accountNo, string CusomerName, double Balance)
        {
            this.accountNo = accountNo;
            this.CustomerName = CustomerName;
            this.Balance = Balance;
            Console.WriteLine("in paraneterized constructor");
        }
        void depositeamount()
        {

        }
        void withdraw()
        {

        }
        void checkbalance()
        {

        }
    }
      class Task
        {
        static void Main(string[] args)
        {
            Account obj = new Account(888675768,"nansjf",6757698);
        }

        }

    class Account
    {
        public long ACNo { get; set; }
        public string CName { get; set; }
        public float Balance { get; set; }

        public Account()
        {
            ACNo = 8977877667;
            CName = "Jayesh";
            Balance = 89889.98f;
            Console.WriteLine("In Default Constructor.");
        }
        public Account(long ACNo, string CName, float Balance)
        {
            this.ACNo = ACNo;
           this.CName = CName;
           this.Balance = Balance;
            Console.WriteLine("In Parameterised Constructor");
        }
        public void DepositedAmmount(int DA)
        {
            Console.WriteLine(DA);
        }
        public void Withdraw( int WD)
        {
            Console.WriteLine(WD);
        }
        public void CheckBalance()
        {
            Console.WriteLine(Balance);
        }
    }
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            
        }

    }
}

