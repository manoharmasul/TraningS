using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the num");
                int num = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("input must be numeric");
            }
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(i);
            }
        }

    }
    class ExceptionDemo1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the num1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the num2");
                int num2 = int.Parse(Console.ReadLine());

                int num = num1 / num2;
                Console.WriteLine(num);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("input must be numeric");
            }
            catch(DivideByZeroException e1)

            {
                Console.WriteLine(e1.Message);
                Console.WriteLine("divisor can not be");
            }
            finally
            {
                Console.WriteLine("in finally");

            }
            Console.WriteLine("end program");
        }
    }
    public class DivideByOddNoExceptin : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number.";

            }
        }
    }
   
    class ExceptionDemo2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value num2");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 % 2 > 0)
            {
                try
                {
                    //  throw new ApplicationException("Divisor value cannot be odd num");
                    throw new DivideByOddNoExceptin();

            }

                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
            int num = num1 / num2;
            Console.WriteLine(num);
            }

        }
    }
    //defining outr own Exception Classes
 /*   public class DivideByOddNoExceptin:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number.";


        }
    }
    }*/
  
    class Exception5
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 5, 4, 7, 8, 5, 8 };
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
               
                
            }
        }
    }
    class ExceptionHadlingDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Add();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Add()
        {
            Console.WriteLine("Enter the Value x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value y");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
        }
    }

}
