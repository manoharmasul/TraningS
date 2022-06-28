using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    class StringDemo
    {
        
        static void Main(string[] args)
        {
            string str = "Manohar";
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Length);
            
        }

    }
    class String_Revers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string ");
            string str = Console.ReadLine();
            string rev = "";
            for(int i=0;i<str.Length;i++)
            {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);
        }
    }
    class StringAnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st string ");
            string st1 = Console.ReadLine();
            Console.WriteLine("Enter The 2nd String ");
            string st2 = Console.ReadLine();

            string str1 = st1.ToLower();
            string str2 = st2.ToLower();

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(string.Join("",ch1));
            Console.WriteLine(string.Join("",ch2));

            string s1 = new string(ch1);
            string s2 = new string(ch2);
            
            if(s1.CompareTo(s2)==0)
            {
                Console.WriteLine("strings are anagram");

            }
            else
            {
                Console.WriteLine("string are not anagram");
            }
        }
    }
    class StringPalendrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string str = Console.ReadLine();

            string rew = "";
            for (int i = 0; i < str.Length; i++)
            {
                rew = str[i] + rew;

            }
            Console.WriteLine(rew);
            /*  if(str.CompareTo(rew)==0)
              {
                  Console.WriteLine("yes");
              }*/
            if (str == rew)
            {
                Console.WriteLine("string is palendrom");

            }
            else
            {
                Console.WriteLine("string not palendrom");
            }

        }

    }
    class DuplicatesWords
    {
        static void Main(string[] args)
        {
            string str = "Big black bug bit a big black dog on his big black nose";
            int count;
            str = str.ToLower();
            string[] words = str.Split(' ');
            Console.WriteLine("Duplicate words in a given string ");
            for(int i=0;i<words.Length;i++)
            {
                count = 1;
                for(int j=i+1;j<words.Length;j++)
                {
                    if(words[i].Equals(words[j]))
                    {
                        count++;
                        words[j] = "0";
                    }
                }
                if(count>1&&words[i]!="0")
                    Console.WriteLine(words[i]);
            }
        }
    }
   
}
