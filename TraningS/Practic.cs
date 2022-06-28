using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace TraningS
{
    class Practic
    {
    }
    class ArrayList_DuplicateR
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
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
           // Console.WriteLine(al[1]);
            for(int i=0;i<al.Count;i++)
            {
                for(int j=i+1;j<al.Count;j++)
                {
                    if (al[i].ToString() == al[j].ToString())
                        al.Remove(al[j]);
                    
                }
            }
            foreach (object obj in al)
                Console.WriteLine(obj);
        }
    }
}
