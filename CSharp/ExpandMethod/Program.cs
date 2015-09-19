using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpandMethod
{

    public static class moneyExpandMethod
    {
        public static  void Add(this Money money, decimal amount)
        {
            money.Amount += amount;
        }
    }

    public class Money
    {
        public decimal Amount
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "$" + Amount.ToString();

        }
    }
    class Program
    {  
        static void Main(string[] args)
        {
            Money money = new Money();
            money.Amount = 100000;

            money.Add(1000);
            Console.Write(money.Amount);
            Console.ReadLine();
        }
    }
}
