using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLamdbaEvent
{
    class Date
    {
        string year;
        string month;
        public Date(string _y, string _m)
        {
            this.year = _y;
            this.month = _m;
        }

        public override string ToString()
        {
            return year+"年"+month+"月";
        }
    }
    class Program
    {
        delegate double ReturnDouble();
        delegate string GetAString();
        static void Main(string[] args)
        {
            int x = 0;
            GetAString str = new GetAString(x.ToString);
            Console.WriteLine(str());

            Date date = new Date("2014", "11");

            str = date.ToString;

            Console.WriteLine(str());


            Console.ReadKey();
        }
    }
}
