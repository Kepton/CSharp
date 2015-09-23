using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    class myclass
    {
 
    }


    public class myList<c>
    {
        public c value;

        public c getValue()
        {
            return value;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            var kk = new myList<int>();
            kk.value = 30;

            Console.WriteLine(kk.getValue());

            Console.ReadKey();
        }
    }
}
