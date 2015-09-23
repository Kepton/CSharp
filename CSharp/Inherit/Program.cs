using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inherit
{

    interface Ikk { }
    interface Icc
    {
       
        void setAmount(decimal _amount);

       decimal getAmount();

       void addAmount(decimal _amount);

    }


    public class Amount : Icc
    {
        private  decimal amount;
        public   void setAmount(decimal _amount)
        {
            this.amount = _amount;
        }
        public  decimal getAmount()
        {
            return amount;
        }

        public void addAmount(decimal _amount)
        {
            amount += _amount;
        }
    }



    public class DoubleAmount : Icc
    {
        private decimal amount;
        public void setAmount(decimal _amount)
        {
            this.amount = _amount*2;
        }
        public decimal getAmount()
        {
            return amount*2;
        }

        public void addAmount(decimal _amount)
        {
            amount += _amount*2;
        }

        public void Clear()
        {
            this.amount = 0;
        }

    }

    public class BaseClass
    {
        private string Name = "";


        

        public BaseClass():base()
        {
            this.Name = "<no name>";
            Console.WriteLine("Base");
        }
        public BaseClass(string kk)
        {
            Console.WriteLine("Base string kk");
        }


        public virtual void virtualMehtod()
        {
            Console.WriteLine("this is a base virtual method");
        }

        public void MyConMethod()
        {
            Console.WriteLine("this is  the same base method");
        }
    }

    public class InhertClass:BaseClass
    {
        public InhertClass(string kk)
        {
            Console.WriteLine("Inherit kk");
        }
        //public InhertClass()
        //{
        //    Console.WriteLine("Inherit");
        //}

        public override  void virtualMehtod()
        {
            Console.WriteLine("this is override method");
        }

        public new void MyConMethod()
        {
            Console.WriteLine("this is  the same inhert method");
        }
    }

   public  abstract class MyabstractClass
    {
        public string Name;

        public MyabstractClass(string Name)
        {
            this.Name = Name;
        }

       public MyabstractClass()
       {
           this.Name = "base Name";
           Console.WriteLine("no param BaseNmae");
       }
   

       public  abstract string GetName();

    }

    public abstract class MychildClass:MyabstractClass
    {
        public MychildClass(string Name)
        {
            this.Name = "";
        }
        public override string GetName()
        {
            return base.Name;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Icc normal = new Amount();
            Icc doubleamount=new DoubleAmount();
             DoubleAmount doubleamount1=new DoubleAmount();
            normal.addAmount(1000);
            doubleamount.addAmount(1000);
            doubleamount1.Clear();
            
            Console.WriteLine(normal.getAmount());
            Console.WriteLine(doubleamount.getAmount());
            Console.ReadKey();
        }
    }
}
