//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Collections;
//namespace TraningS
//{
//    class Practic
//    {
//    }
//    class ArrayList_DuplicateR
//    {
//        static void Main(string[] args)
//        {
//            ArrayList al=new ArrayList();
//            al.Add("sun");
//            al.Add("mon");
//            al.Add("sat");
//            al.Add("sun");
//            al.Add("mon");
//            al.Add("sat");
//            al.Add("sun");
//            al.Add("sat");
//            al.Add("sun");
//            al.Add("mon");
            
//            ArrayList al1 = new ArrayList();
//            foreach(string obj in al)
//            {
//                if (al1.Contains(obj) == false)
//                    al1.Add(obj);
//            }
//            foreach(string ob in al1 )
//            {
//                Console.WriteLine(ob);
//            }

//        }
//    }
//    class SortArrayListReverse
//    {
//        static void Main(string[] args)
//        {
//            ArrayList al = new ArrayList();
//            al.Add("Manohar");
//            al.Add("Sambhaji");
//            al.Add("Mansi");
//            al.Add("Vidya");
//            al.Add("Alexa");
//            al.Sort();
//            // al.Reverse();
//          // foreach(string A in al)
////Console.WriteLine(A);
//            for (int i = al.Count-1; i >= 0; i--)
//            {
//                Console.WriteLine(al[i]);
//            }
//        }
//    }
//  class HashDemo
//  {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();
//            ht.Add("1", "Manohari");
//            ht.Add("2","Sambhaji");
//            ht.Add("3","Vidya");
//            ht.Add("4","Mansi");
//            ht.Add("5","Rushi");
//            ht.Add("6","Raghav");

//            object key = Console.ReadLine();
//            object value = Console.ReadLine();
//            ht[key] = value;
//            foreach(DictionaryEntry ob in ht)
//            {
//                Console.WriteLine(ob.Key+":"+ob.Value);
//            }
//            Console.ReadLine();
//        }
//  }
//    class HatashU
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add("1","One");
//            ht.Add("2","Two");
//            ht.Add("3","Three");
//            ht.Add("4","Four");
//            ht.Add("5", "Five");
//            object key = Console.ReadLine();
//            object val = Console.ReadLine();
//            ht[key] = val;
//            foreach(DictionaryEntry d in ht)
//            {
//                Console.WriteLine(d.Key+" "+d.Value);
//            }
//            Console.ReadLine();


//        }
//    }
//    class Hatash2
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add("1", "One");
//            ht.Add("2", "Two");
//            ht.Add("3", "Three");
//            ht.Add("4", "Four");
//            ht.Add("5", "Five");



//            foreach (DictionaryEntry d in ht)
//            {
//                Console.WriteLine(d.Key + " " + d.Value);
//            }
//            Console.ReadLine();


//        }
//    }
//    class RemoveHt
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();
//            ht.Add(1,"A");
//            ht.Add(2,"B");
//            ht.Add(3,"C");
//            ht.Add(4,"D");
//            ht.Add(5,"E");
//            ht.Add(6,"F");
//            ht.Add(7,"G");
//            ht.Add(8,"H");
//            ht.Add(9,"I");
//            ht.Add(10,"J");
//            ArrayList al = new ArrayList();

//            foreach (var ob in ht.Keys)
//            {
//                int n = Convert.ToInt32(Console.ReadLine());
//                if(n%3==0)
//                {
//                    al.Add(ob);
//                }
//            }
           
//            for (int i=0;i<al.Count;i++)
//            {
//                ht.Remove(al[i]);
//            }
//            foreach (DictionaryEntry ob in ht)
//            {
//                Console.WriteLine(ob.Key + " : " + ob.Value);
//            }
//        }
//    }
//    class Freq
//    {
//        static void Main(string[] args)
//        {
//            ArrayList al = new ArrayList();
//            al.Add("Pune");
//            al.Add("Mumbai");
//            al.Add("Nasik");
//            al.Add("Pune");
//            al.Add("Mumbai");
//            al.Add("Nasic")

//            Hashtable ht = new Hashtable();
//            for(int i=0;1<al.Count;i++)
//            {
                             
//            }

//        }
//    }
//}
