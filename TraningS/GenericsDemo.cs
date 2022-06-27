using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TraningS
{
    class GenericsDemo
    {
    }
    class listDemo00
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(7);
            li.Add(8);
            li.Add(89);
            li.Add(43);
            // li,Add("mano");
            foreach (int ob in li)
                Console.WriteLine(ob);
        }
    }
    public class Customer
    {

        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    /* class listdemo22
      {
          static void main(string[] args)
          {
              list<costomer> customers = new list<costomer>();

          }
      }*/
    class DictionaryDemo1
    {

        static void Main(string[] args)
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            // dt.Add(89, "man");
            dt.Add("Eid", 9898);
            dt.Add("Name", "manohar");
            dt.Add("Role", "Developer");
            dt.Add("Phone", 9823578407);
            dt.Add("Email", "manyaeksafar@gmail.com");
            foreach (string key in dt.Keys)
                Console.WriteLine(key + ":" + dt[key]);
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
            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }
            Console.WriteLine(d1.ContainsKey(101));
            Console.WriteLine(d1.ContainsValue("makdk"));

        }
    }
        class DictionaryDemo5
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
            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }
            Console.WriteLine(d1.ContainsKey(101));
            Console.WriteLine(d1.ContainsValue("makdk"));

        }
    }
    class ListDemo01
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer { Custid = 201, Name = "Manohar", City = "Nashik", Balance = 30009 };
            Customer c2 = new Customer { Custid = 202, Name = "Manasi", City = "Bhoom", Balance = 56868 };
            Customer c3 = new Customer { Custid = 203, Name = "Viky", City = "Nampur", Balance = 2909 };
            Customer c4 = new Customer { Custid = 204, Name = "Raj", City = "jalagaon", Balance = 30909 };
            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);

            foreach (Customer obj in Customers)
            {
                Console.WriteLine(obj.Custid + ":" + obj.Name + ":" + obj.City + ":" + obj.Balance);
            }
        }
    }
   class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

       /* public int CompareTo([AllowNull] Student other)
        {
            
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;

        }*/

          public int CompareTo(Student other)
          {
              if (this.Marks > other.Marks)
                 return -1;
                  else if (this.Marks < other.Marks)
                          return 1;
                      else
                          return 0;
          }
    }
    class CompareStudent : IComparer<Student>
    {
        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            if (x.Class > y.Class)
                return 1;
            else if (x.Class < y.Class)
                return -1;
            else
                return 0;
        }
    }
    class TestStudd
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Sid = 122, Name = "Manohar", Class = 12, Marks = 467.00f };
            Student s2 = new Student { Sid = 121, Name = "Manasi", Class = 4, Marks = 356.00f };
            Student s3 = new Student { Sid = 124, Name = "Ajit", Class = 11, Marks = 450.00f };
            Student s4 = new Student { Sid = 123, Name = "Vijay", Class = 10, Marks = 466.00f };

            List<Student> st = new List<Student>() { s1, s2, s3, s4 };
            CompareStudent obj = new CompareStudent();
            st.Sort(obj);
           // st.Reverse();
            // st.Sort();//its complex type containing multiple value complr confused
            // which value the sorting has to be performed
            foreach (Student ob in st)
                Console.WriteLine(ob.Sid+":"+ob.Name+":"+ob.Class+":"+ob.Marks);
        }
    }
}
