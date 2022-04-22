using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate d = new MyDate(27, 03, 2022);
            Console.WriteLine(d);
            bool check = d.IfLeap();
            check = d.IfToDay();
            d++;
            Console.WriteLine(d);
            check = d.IfToDay();
        }
    }
}
