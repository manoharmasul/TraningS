using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace TraningS
{
    class CollectinsDemo
    {
    }
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Manohar");
            al.Add("Eston");
            al.Add(89);
            al.Add(90.4f);
            al.Add(9.000);

            foreach (object obj in al)
                Console.WriteLine(obj);

        }
    }
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",101);
            ht.Add("Name","Manohar");
            ht.Add("Email","Manohar@gmail.com");
            ht.Add("Phone",9898897787);
            ht.Add("Dname","Sales");
            ht.Add("Location","pune");
            ht.Add("Age",22);
            Console.WriteLine("Hello".GetHashCode());
            Console.WriteLine(ht["Email"]);
            foreach(object key in ht.Keys)
                //Console.WriteLine(key );
                Console.WriteLine(key+" : "+ht[key]);
        }
    }
    class ListDemo
    {
        static void Main(string[] args)
        {
            //  List<T> ll = new List<T>();
            List<int> ll = new List<int>();
            ll.Add(9);
            ll.Add(4);
            ll.Add(7);
            ll.Add(6);
           // ll.Add(7.9);
            ll.Add(6);
            ll.Add(4);
            ll.Remove(4);

            for (int i = 0; i < ll.Count; i++)
            {
                Console.Write(ll[i] + ",");

            }
            ll.Insert(3, 444);
            Console.WriteLine();
            foreach(int obj in ll)
                Console.Write(obj+",");
        }
    }
    class DictionaryDemo3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "manohar");
            d1.Add(102, "mansi");
            d1.Add(103, "Arohi");
            d1.Add(103, "Jadhav"); //Duplicate allowed
            //to get value Corresponding to key
            Console.WriteLine(d1[102]);
            //Replace
            d1[102] = "Anushka";
            //Remove
            d1.Remove(101);
            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }
            Console.WriteLine(d1.ContainsKey(101));
            Console.WriteLine(d1.ContainsValue("makdk"));

        }
    }
    class Studd : IComparable<Studd>
    {
        int Sid;
        string Name;
        int Marks;
        public Studd(int sid, string name, int marks)
        {
            Sid1 = sid;
            Name1 = name;
            Marks1 = marks;
        }
        public int Sid1 { get => Sid; set => Sid = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Marks1 { get => Marks; set => Marks = value; }

        public int CompareTo(Studd other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
    class CompareStudent : IComparer<Studd>
    {
        public int Compare(Studd x, Studd y)
        {
            if (x.Marks1 > y.Marks1)
                return 1;
            else if (x.Marks1 < y.Marks1)
                return -1;
            else
                return 0;


        }
    }
    class StudddTT
    {
        static void Main(string[] args)
        {
            List<Studd> Students = new List<Studd>();
            Students.Add(new Studd(101, "Manohar", 100));
            Students.Add(new Studd(103, "Manasi", 98));
            Students.Add(new Studd(102, "Vijay", 99));
            //  Students.Sort();//1st
            CompareStudent ob = new CompareStudent();
            Students.Sort(ob);
            foreach (Studd obj in Students)

                Console.WriteLine(obj.Sid1 + " : " + obj.Name1 + " : " + obj.Marks1);
        }

    }
    public class Customer
    {
        int Custid;
        string Name;
        string City;
        double Balance;

        public Customer(int custid, string name, string city, double balance)
        {
            Custid1 = custid;
            Name1 = name;
            City1 = city;
            Balance1 = balance;
        }

        public int Custid1 { get => Custid; set => Custid = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string City1 { get => City; set => City = value; }
        public double Balance1 { get => Balance; set => Balance = value; }
    }
    class ListDemo01
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            /*   Customer c1 = new Customer { Custid1 = 201, Name1 = "Manohar", City1 = "Nashik", Balance1 = 30009 };
               Customer c2 = new Customer { Custid1 = 202, Name1 = "Manasi", City1 = "Bhoom", Balance1 = 56868 };
               Customer c3 = new Customer { Custid1 = 203, Name1 = "Viky", City1 = "Nampur", Balance1 = 2909 };
               Customer c4 = new Customer { Custid1 = 204, Name1 = "Raj", City1 = "jalagaon", Balance1 = 30909 };
               Customers.Add(c1);
               Customers.Add(c2);
               Customers.Add(c3);
               Customers.Add(c4);*/
            Customers.Add(new Customer(201, "Manohar", "Nashik", 778786));
            Customers.Add(new Customer(201, "Manasi", "Osmanabad", 7787889));
            Customers.Add(new Customer(201, "manohar", "Mumbai", 889786));
            Customers.Add(new Customer(201, "manohar", "jalagaon", 7999786));

            foreach (Customer obj in Customers)
            {
                Console.WriteLine(obj.Custid1 + ":" + obj.Name1 + ":" + obj.City1 + ":" + obj.Balance1);
            }
        }
    }
  
    class Dictionarydemo5
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(102, "mansi");
            d1.Add(103, "arohi");
           // to get value corresponding to key
            Console.WriteLine(d1[102]);
            //replace
            d1[102] = "anushka";
           // remove
            d1.Remove(101);
            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }
            Console.WriteLine(d1.ContainsKey(101));
            Console.WriteLine(d1.ContainsValue("makdk"));

        }
    }
    class stackdsemo
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(99);
            object data1 = st.Pop();
            st.Push("manihar");
            st.Push(45);
            st.Push(50);

            object data = st.Pop();
            foreach (object ob in st)

                Console.WriteLine(ob);
        }
    }
    class queuedemo
    {
        static void Main(string[] args)

        {
            Queue ql = new Queue();
            ql.Enqueue(34);
            ql.Enqueue(67);
            ql.Enqueue(44.45f);
            ql.Enqueue(67);
            ql.Enqueue("Raj");
            ql.Enqueue(true);
            ql.Enqueue(9);
            ql.Enqueue(90.99);
           
            foreach(var item in ql)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("remove 1st element"+ ql.Dequeue());
            Console.WriteLine("remove 2nd element"+ ql.Dequeue());
            Console.WriteLine("///////////////////////////////////");
            foreach(var item in ql)
            {
                Console.WriteLine(item);
            }
        }
    }
    ////////////////////////////////////////////////////////////////////
    class ArrayList_DuplicateR
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("sun");
            al.Add("mon");
            al.Add("sat");
            al.Add("sun");
            al.Add("mon");
            al.Add("sat");
            al.Add("sun");
            al.Add("sat");
            al.Add("sun");
            al.Add("mon");

            ArrayList al1 = new ArrayList();
            foreach (string obj in al)
            {
                if (al1.Contains(obj) == false)
                    al1.Add(obj);
            }
            foreach (string ob in al1)
            {
                Console.WriteLine(ob);
            }

        }
    }
    class SortArrayListReverse
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Manohar");
            al.Add("Sambhaji");
            al.Add("Mansi");
            al.Add("Vidya");
            al.Add("Alexa");
            al.Sort();
            // al.Reverse();
            // foreach(string A in al)
            //Console.WriteLine(A);
            for (int i = al.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
    class HashDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Manohari");
            ht.Add("2", "Sambhaji");
            ht.Add("3", "Vidya");
            ht.Add("4", "Mansi");
            ht.Add("5", "Rushi");
            ht.Add("6", "Raghav");

            object key = Console.ReadLine();
            object value = Console.ReadLine();
            ht[key] = value;
            foreach (DictionaryEntry ob in ht)
            {
                Console.WriteLine(ob.Key + ":" + ob.Value);
            }
            Console.ReadLine();
        }
    }
    class HatashU
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("1", "One");
            ht.Add("2", "Two");
            ht.Add("3", "Three");
            ht.Add("4", "Four");
            ht.Add("5", "Five");
            object key = Console.ReadLine();
            object val = Console.ReadLine();
            ht[key] = val;
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            Console.ReadLine();


        }
    }
    class Hatash2
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("1", "One");
            ht.Add("2", "Two");
            ht.Add("3", "Three");
            ht.Add("4", "Four");
            ht.Add("5", "Five");



            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            Console.ReadLine();


        }
    }
    class RemoveHt
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "A");
            ht.Add(2, "B");
            ht.Add(3, "C");
            ht.Add(4, "D");
            ht.Add(5, "E");
            ht.Add(6, "F");
            ht.Add(7, "G");
            ht.Add(8, "H");
            ht.Add(9, "I");
            ht.Add(10, "J");
            ArrayList al = new ArrayList();

            foreach (int ob in ht.Keys)
            {
                if (ob % 3 == 0)
                {
                    al.Add(ob);
                }
            }

            for (int i = 0; i < al.Count; i++)
            {
                ht.Remove(al[i]);
            }
            foreach (DictionaryEntry ob in ht)
            {
                Console.WriteLine(ob.Key + " : " + ob.Value);
            }
        }
    }
}
