using System;
namespace TraningS
{
    //we do not create explict contr there will be 1 default contr 
    //if we declare n constr so n+1 default contr present 
    struct  Mystruct
    {
        //  int i = 10;//fields of class can be initialized at the time of declaration but not in struct
        int i;
        //public Mystruct()
        //{
        //    //struct cannot contain explicit constructor
        //}
        public Mystruct(int i)
        {
            this.i = i;
        }
        public void Display()
        {
            
            Console.WriteLine("metheod in a structure "+i);
        }
        static void Main(string[] args)
        {
           // Mystruct m = new Mystruct();
           //you mst be initialized each and every field

            Mystruct m1; m1.i = 10;//new is optional in struct 
            m1.Display();
            Mystruct m2 = new Mystruct();
                m2.Display();
            Mystruct m3 = new Mystruct(89);
            m3.Display();


        }
    }
}