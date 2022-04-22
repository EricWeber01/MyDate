using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    internal class MyDate
    {
        class Date
        {
            protected DateTime date { set; get; }
        }
        class MyDate: Date
        {
            public MyDate(int d, int m, int y)
            {
                date = new DateTime(y, m, d);
            }
            public bool IfLeap()
            {
                if (date.Year % 4 == 0 && (date.Year % 400 == 0 || date.Year % 100 != 0))
                {
                    Console.WriteLine("Год высокосный");
                    return true;
                }
                else
                {
                    Console.WriteLine("Год не высокосный");
                    return false;
                }
            }
            public bool IfToDay()
            {
                DateTime today = DateTime.Today;
                if (date < today)
                {
                    Console.WriteLine("Дата раньше текущей");
                    return false;
                }
                else if (date == today)
                {
                    Console.WriteLine("Введена текущая дата");
                    return true;
                }
                else
                {
                    Console.WriteLine("Дата позже текущей");
                    return true;
                }
            }
            public static MyDate operator ++(MyDate md)
            {
                return new MyDate(md.date.Day + 1, md.date.Month, md.date.Year);
            }
            public override string ToString()
            {
                return $"{date.ToLongDateString()}";
            }
        }
    }
}