using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {


            int[] arr = { 9, 6, 4, 6, 7, 43, 6, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
    class ArrayOddno
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 4, 5, 3, 76, 78, 6, 5, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
    class ArraySum
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 5, 4, 6, 3, 2, 9 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i] + sum;

            }
            Console.WriteLine(sum); ;
        }
    }

    class ArraySortDemo
    {
        //Dccending order
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 4, 6, 7, 3, 56, 76, 66, 55 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class ArraySortDemoA
    {
        //Accending Order
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 4, 6, 7, 3, 56, 76, 66, 55 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class MaxArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 8, 2, 3, 9, 6, };
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine(max);
        }
    }
    class MinArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 8, 2, 3, 9, 6, };
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine(min);
        }
    }
    class ArrayNoCheck
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 4, 5, 2, 7, 8, 90 };
            //int count = 0;
            Console.WriteLine("Enter the no to check present or not");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<arr.Length;i++)
            {
             if(arr[i]==num)
                {
                    Console.WriteLine(num + "nume is present and index is" + i);

                }
            }

        }
    }

}

