using System;
using System.Collections.Generic;
using System.Text;
namespace TraningS
{
    //create class teacher with following

    //    tid,tname,mobileno
    //    parameterized constructor
    //    abstract void salary()
    //create class hourlybased which is derived class from teacher with fields
    //     rate_per_hr,

    //    int hrs;
    //parameterized constructor

    //    void salary()
    //create class salarybased which is derived class from teacher
    //    with fields
    //    int salary;
    //parameterized constructor

    //    void salary()
    //write main to create objects of hourlybased teacher and salarybased teacher and also call respective salary method and also show runtime polymorphism

        abstract class Teacher
        {
            public int Tid;
            public string Tname;
            public long Mno;

            public Teacher(int tid, string tname, long mno)
            {
                Tid = tid;
                Tname = tname;
                Mno = mno;
            }
            public abstract void Salary();

        }
        class HourseBased : Teacher
        {
            int Hrs;
            int ReatePerHrs;

            public HourseBased(int tid, string tname, long mno, int hrs, int reatePerHrs) : base(tid, tname, mno)
            {
                Hrs = hrs;
                ReatePerHrs = reatePerHrs;
            }
            public override void Salary()
            {
                Console.WriteLine(Hrs * ReatePerHrs);
            }

        }
        class SalaryBased : Teacher
        {
            int Sal;

            public SalaryBased(int tid, string tname, long mno, int sal) : base(tid, tname, mno)
            {
                Sal = sal;
            }

            public override void Salary()
            {
                Console.WriteLine(Sal);
            }
        }
        class SalCheck
        {
            static void Main(string[] args)
            {
                Teacher obj1 = new HourseBased(1010, "Manohar", 989798979, 43, 500);
                obj1.Salary();
                Teacher obj2 = new SalaryBased(1011, "Mansi", 86778687, 50000);
                obj2.Salary();
            }
        }



        interface Cake
        {
            void bake();

        }
        class Strawberry
        {
            public void bake()
            {
                Console.WriteLine("in Strawberry");
            }
        }
        class BlackForest
        {
            public void bake()
            {
                Console.WriteLine("in BlackForest");
            }

        }
        class CakeTest
        {
            static void main(string[] args)
            {
                Strawberry obj = new Strawberry();
                obj.bake();
                BlackForest obj1 = new BlackForest();
                obj1.bake();

            }

        }

        interface IIcecream
        {
            void eat();


        }
        interface IJuice
        {
            void drink();

        }
        class Mastani
        {
            public void eat()
            {
                Console.WriteLine("Mastani is eating ");
            }

            public void drink()
            {
                Console.WriteLine("Mastani drinking ");
            }
        }
        class MastaniTest
        {
            static void main(string[] args)
            {
                Mastani obj = new Mastani();
                obj.eat();
                obj.drink();

            }
        }



        //design a class to overload a function volume() as follows:  [2m]
        //(i)double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
        //v = 4 / 3 × 22 / 7 × r3
        //(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r
        //as the arguments, returns the volume of a cylinder using the formula:
        //v = 22 / 7 × r2 × h
        //(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, returns the volume of a cuboid using the formula:
        //v = l × b × h

        class Volume
        {

            public double volume(double r)
            {
                return (4 / 3) * (22 / 7) * (r * r * r);
            }
            public double volume(double h, double r)
            {
                return (22 / 7) * (r * r) * (h);
            }
            public double volume(double l, double b, double h)
            {
                return (l * b * h);
            }
        }
        class PrinttVal
        {
            static void main(string[] args)
            {
                Volume obj = new Volume();

                Console.WriteLine(obj.volume(2.45));
                Console.WriteLine(obj.volume(25.56, 6.55));
                Console.WriteLine(obj.volume(45.45, 67.89, 56.78));
            }
        }
        //wap to find area of square, rectangle, and circle using method overloadi

        class AreaDDemo
        {
            public void area(float r)

            {
                Console.WriteLine("area of circle is" + 3.14 * r * r);
            }
            public void area(int a)
            {

                Console.WriteLine("area of squre" + a * a);
            }

            public void area(int b, int h)
            {
                Console.WriteLine("area of rectagle" + b * h);

            }
        }
        class printarea
        {
            static void main(string[] args)
            {
                AreaDDemo obj = new AreaDDemo();
                obj.area(5.8f);
                obj.area(7);
                obj.area(5, 8);
            }

        }
    
}