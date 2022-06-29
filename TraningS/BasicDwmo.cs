using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    class BasicDwmo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class PrimeNO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
    class Fseries
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n;
           
            Console.WriteLine("Enter the num last no of Fseries");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + "," + n2+",");
            for (int i=2;i<num;++i)
            {
                n = n1 + n2;
                Console.Write(n+",");
                n1 = n2;
                n2 = n;


            }
        }

    }
//    Write a program to print even numbers from 121 to 229 using for loop.
class even_no
    {
        public static void Main()
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
    //		 Write a program to print odd numbers from 521 to 229 using while loop.
    class Odd_no
    {
        public static void Main()
        {
            int i = 521;
            while (i >= 229)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ",");

                }
                i--;

            }
        }
    }
        //Write a program to show the use of break statement.
        class break_use
        {
            public static void Main()
            {
                Console.WriteLine("Emter the no to break loop");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 20; i++)
                {
                    Console.Write(i + ",");
                    if (i == n)
                    {
                        break;
                    }
                }
            }
        }
    class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());


            int gcd = 0;

            for (int i = 1; i >= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {

                    gcd = i;

                }
            }

            Console.WriteLine("gcd" + gcd);
            int lcm = a * b / gcd;

            Console.WriteLine("lcm=" + lcm);

        }
    }
    class print_char
    {
        public static void Main()
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                Console.Write(ch + ",");
            }
        }
    }
  //  Write a program to find sum of all even numbers between 1 to n
class Odd_sum
    {
        public static void Main()
        {
            Console.WriteLine("emter the nth no");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = i + sum;
                }

            }
            Console.WriteLine(sum);
        }
    }
  //  Write a program to find sum of all odd numbers between 1 to n.
    class even_sum1
    {
        public static void Main()
        {
            Console.WriteLine("emter the nth no");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = i + sum;
                }

            }
            Console.WriteLine(sum);
        }
    }

}





