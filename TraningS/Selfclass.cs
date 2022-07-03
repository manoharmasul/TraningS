using System;
using System.Collections.Generic;
using System.Text;

namespace TraningS
{
    class Selfclass
    {

    }
    class propertiesDemo
    {
        double Radius = 20.34;
       public double dia = 40.68;
        public double GetRadius()//provid only get access to the value
        {
            return Radius;
        }
        public void SetRadius(double value )//provide only set access to value
        {
            Radius = value;
        }
     

    }
    class testcc
    {
        static void Main(string[] args)
        {
            propertiesDemo obj = new propertiesDemo();
            //no Console.WriteLine(obj.Radius);
            Console.WriteLine(obj.dia);//yes
            obj.SetRadius(56.44);
        
            Console.WriteLine(obj.GetRadius());
        }
    }
    class propertiesDemo1
    {
        double _Radius = 34.34;
        public double dia = 40.68;

        public double Radius    //radius property
        {                        
            get { return _Radius; }
            set { _Radius = value; }
        }


    }
    class testcc1
    {
        static void Main(string[] args)
        {
            propertiesDemo1 obj = new propertiesDemo1();
            
            Console.WriteLine(obj.dia);
            double Radius = obj.Radius;
            obj.Radius = 78.88;
            Console.WriteLine(obj.Radius);
        }
    }
    class propertiesDemo2
    {
        double _Radius = 34.34;
        public double dia = 40.68;

        public double Radius  //radius property
        {
            get { return _Radius; }
            set
            {
                if (value > _Radius)
                    _Radius = value;
            }

        }

    }
    class testcc2
    {
       static void Main(string[] args)
        {
           propertiesDemo2 obj = new propertiesDemo2();

           Console.WriteLine(obj.dia);
           double Radius = obj.Radius;

           obj.Radius = 78.88;
           Console.WriteLine(obj.Radius);
            
       }
    }
    class Customerr
    {
        int _Custid;
        bool _Status;
        string _Cname;
        double _Balance;
      //  public int DD;
        public Customerr(int Custid,bool Status,string Cname,double Balance)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;

        }
        public int Custid
        {
            get { return _Custid; }
            set { _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set 
            {
                if(_Status==true)
                _Cname = value; 
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set            { 
            if(_Status==true)    
             _Balance = value;
            }
        }


    }
    class TestCust
    {
        static void Main(string[] args)
        {
            Customerr obj = new Customerr(1, false, "Manohar", 2244.00);
            // obj.DD = 90;
            //  obj.Custid;not possible;

            Console.WriteLine("Cust id"+obj.Custid);
            //  Console.WriteLine(obj.Status);
            if (obj.Status == false)
            {
                Console.WriteLine("Costomer Status Inactive");
            }
            else
                Console.WriteLine("active");

            Console.WriteLine("Cust Name "+obj.Cname);
            obj.Cname += " mass";
            Console.WriteLine("Cust Name " + obj.Cname);


            Console.WriteLine("balance "+obj.Balance);

            Console.WriteLine("//////////////////////////////////////////////////////");

            obj.Custid = 4;
            obj.Status = false;
            if (obj.Status == false)
            {
                Console.WriteLine("Costomer Status Inactive");
            }
            else
                Console.WriteLine("Costomer Status active");

            obj.Cname += " manohar";
            obj.Status = true;
           
             
            Console.WriteLine("Cust id " + obj.Custid);
            //  Console.WriteLine(obj.Status);
            if (obj.Status == false)
            {
                Console.WriteLine("Costomer Status Inactive");
            }
            else

                Console.WriteLine("Costomer Status active");

            obj.Balance -= 1000.99;
            Console.WriteLine("Cust Name " + obj.Cname);

                Console.WriteLine("balance " + obj.Balance);

        }
                       
    }


}
