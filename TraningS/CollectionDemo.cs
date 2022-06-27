using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace TraningS
{
    class CollectionDemo4454
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(89);
            al.Add(65);
            al.Add(43);
            al[1] = 5454;
            al.Remove(43);
            al.Add("manohar");
            al.Add(5.5f);
            foreach (object obj in al)
            {
                Console.WriteLine(obj);
            }
        }
    }
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(43);
            ll.Add(56);
            ll.Add(33);
            ll.Add(22);
            //Type safe        ll.Add("manohar");
            foreach (int ob in ll)
            {
                Console.WriteLine(ob);
            }

        }
    }
    class StackDemo
    {
        static void Main(string[] args)
        {


            Stack<string> st = new Stack<string>();
            st.Push("manohar");
            st.Push("manasi");
            st.Push("madhuri");
            st.Push("Arohi");
            

            foreach (string sd in st)

                Console.WriteLine(sd);

            string data = st.Pop();
            Console.WriteLine("data Removed" + data);

            Console.WriteLine("------------------------------------------");

            foreach (object tt in st)

                Console.WriteLine(tt);


        }
    }
   
        class KinkedListDemo
        {
            //allow duplicats
            static void Main(string[] args)
            {
                LinkedList<int> lk = new LinkedList<int>();
                lk.AddLast(50);
                lk.AddFirst(70);
               // lk.AddAfter(40);

            }
        }

    
}


