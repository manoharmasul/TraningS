using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace TraningS
{
    class CollectionDemo
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
            foreach(object obj in al)
            {
                Console.WriteLine(obj);
            }
        }
    }
  class ListDemo2
    {
        static void Main(string[] args)
        {
            List < int > ll= new List<int>();
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

                Console.WriteLine("data Removed"+data);

                Console.WriteLine("------------------------------------------");

                foreach(object tt in st)
                
                    Console.WriteLine(tt);


        }
    }
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "manohar");
            d1.Add(102, "mansi");
            d1.Add(103, "Arohi");
            //to get value Corresponding to key
            Console.WriteLine(d1[102]);
            //Replace
            d1[102] = "Anushka";
            //Remove
            d1.Remove(101);
            foreach(KeyValuePair<int,string>kv in d1)
            {
                Console.WriteLine(kv.Key+"=>"+kv.Value);
            }
            Console.WriteLine(d1.ContainsKey(101));
            Console.WriteLine(d1.ContainsValue("makdk"));

        }
    }
    class ArrayLD
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(11);
            al.Add("Manohari");
            al.Add("Mansi");
            al.Add("Vidya");
            al.Add(86.00);
            al.Add("Raghav");

            //  al.Insert(3, "Priya");//incert the new item
            // al.Remove("Manohari");//remove using object 
            //  al.RemoveAt(2);//remove using index 
            //  al.RemoveRange(0, 2);//remove the range
            //al.Sort();
            int x = al.Count;
            Console.WriteLine( x);
            foreach(object obj in al)
                Console.WriteLine(obj);
        }
    }
    class HashTableHH
    {
        static void Main(string[] args)
        {
            Hashtable ht =new  Hashtable();
            ht.Add("id", 101);
            ht.Add("Ename", "Manohari");
            
           // ht.Add("id", 101);
            ht.Add("Email", "manohari@gmail.com");
            // string name = ht["Ename"].ToString(); //return value of key
            // Console.WriteLine(name);
            ht.Remove("Email");


            foreach(DictionaryEntry d in ht)
                Console.WriteLine(d.Key+" "+d.Value);

        }
    }
     class SortedListDD
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("name","Manohar"); ;
            sl.Add("id", 89);
            sl.Add("Email", "manoharmasul@gmail.com");
            sl.Add("Rank",101);
            
            Console.WriteLine("Soreted Contains"+ sl.ContainsKey("id")+"  contains  value" + sl.ContainsValue("Manohar"));
            foreach(DictionaryEntry obj in sl)

                Console.WriteLine(obj.Key+" "+obj.Value);
             //   Console.WriteLine(obj.Key);
            

        }
    }
    class SortedList22
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl= new SortedList<int,string>();
            sl.Add(1, "manohar");
            sl.Add(2, "yogi");
            sl.Add(3, "sambhaji");
            sl.Add(4, "babu");
            //sl.Remove(3);
            sl.IndexOfKey(3);
            foreach(KeyValuePair<int,string> ob in sl)
                Console.WriteLine(ob.Key+" "+ob.Value);



        }
    }

}
